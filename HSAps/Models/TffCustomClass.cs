using HSAps.Models.HSAps;

namespace HSAps.Models
{
    public partial class TffDashBoardClass
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public DateTime? Fecha { get; set; }

        public string Categoria { get; set; } = null!;

        public int Activo { get; set; }

        public string? Telefono { get; set; }

        public string? Email { get; set; }

        public string? Direccion { get; set; }

        public DateTime FechaIngreso { get; set; }
        public string? Imagen { get; set; }
        //asistencia
        public DateTime UltimoRegistro { get; set; }
        public List<TffAsistencium> Asistencias { get; set; }
        //pagos
        public DateTime UltimoPago { get; set; }
        public List<TffPago> Pagos { get; set; }
    }
}
