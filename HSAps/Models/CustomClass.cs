using HSAps.Models.HSAps;

namespace HSAps.Models
{
    public class DashBoardDefinition
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string ContactName { get; set; }
        public string UrlContactName { get; set; }
    }
    public class LoginClass
    {
        public string User { get; set; }
        public string Pwd { get; set; }
    }
    public class PostAllDataClass
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Contenido { get; set; } = null!;

        public string? Imagen { get; set; }

        public string? VideoUrl { get; set; }

        public int Estatus { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int IsActive { get; set; }

        public int Privacidad { get; set; }
        public List<MktComment> Comentarios { get; set; }
        public List<MktPostLike> PostLikes { get; set; }
    }
}
