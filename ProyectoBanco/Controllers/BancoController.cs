using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using static ProyectoBanco.DTOs;
using static ProyectoBanco.Models;

namespace ProyectoBanco.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class BancoController : ControllerBase
    {
        private readonly BancoRepository bancoRepository;
        private readonly IMapper mapper;

        public BancoController(BancoRepository bancoRepository, IMapper mapper)
        {
            this.bancoRepository = bancoRepository;
            this.mapper = mapper;
        }

        [HttpGet("sucursales")]
        public IActionResult ObtenerSucursales()
        {
            var sucursales = bancoRepository.ObtenerSucursales();
            var sucursalesDTO = mapper.Map<IEnumerable<SucursalDTO>>(sucursales);
            return Ok(sucursalesDTO);
        }

        [HttpGet("clientes")]
        public IActionResult ObtenerClientes()
        {
            var clientes = bancoRepository.ObtenerClientes();
            var clientesDTO = mapper.Map<IEnumerable<ClienteDTO>>(clientes);
            return Ok(clientesDTO);
        }

        [HttpGet("clientes/{sucursalId}")]
        public IActionResult ObtenerClientesPorSucursal(int sucursalId)
        {
            var clientes = bancoRepository.ObtenerClientesPorSucursal(sucursalId);
            var clientesDTO = mapper.Map<IEnumerable<ClienteDTO>>(clientes);
            return Ok(clientesDTO);
        }

        [HttpPost("sucursales")]
        public IActionResult AgregarSucursal(SucursalDTO sucursalDTO)
        {
            var sucursal = mapper.Map<Sucursal>(sucursalDTO);
            bancoRepository.AgregarSucursal(sucursal);
            return CreatedAtAction(nameof(ObtenerSucursales), null);
        }

        [HttpPost("clientes")]
        public IActionResult AgregarCliente(ClienteDTO clienteDTO)
        {
            var cliente = mapper.Map<Cliente>(clienteDTO);
            bancoRepository.AgregarCliente(cliente);
            return CreatedAtAction(nameof(ObtenerClientes), null);
        }
    }

}