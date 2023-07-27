namespace ProyectoBanco
{
    using AutoMapper;
    using static ProyectoBanco.DTOs;
    using static ProyectoBanco.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Sucursal, SucursalDTO>();
            CreateMap<Cliente, ClienteDTO>();
        }
    }

}
