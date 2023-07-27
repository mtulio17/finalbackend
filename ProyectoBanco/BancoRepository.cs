using static ProyectoBanco.Models;

namespace ProyectoBanco
{
  

      public class BancoRepository
    {
        private List<Sucursal> sucursales = new List<Sucursal>();
        private List<Cliente> clientes = new List<Cliente>();

        public void AgregarSucursal(Sucursal sucursal)
        {
            sucursal.Id = sucursales.Count + 1;
            sucursales.Add(sucursal);
        }

        public IEnumerable<Sucursal> ObtenerSucursales()
        {
            return sucursales;
        }

        public void AgregarCliente(Cliente cliente)
        {
            cliente.Id = clientes.Count + 1;
            clientes.Add(cliente);
        }

        public IEnumerable<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        public IEnumerable<Cliente> ObtenerClientesPorSucursal(int sucursalId)
        {
            return clientes.Where(c => c.SucursalId == sucursalId);
        }
    }

}

