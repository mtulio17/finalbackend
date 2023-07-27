namespace ProyectoBanco
{
    public class Models
    {
        public class Sucursal
        {
            public int Id { get; set; }
            public string? Nombre { get; set; }
        }

        public class Cliente
        {
            public int Id { get; set; }
            public string? Nombre { get; set; }
            public int SucursalId { get; set; }
        }

    }
}
