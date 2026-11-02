namespace HSAps.Models
{
    public partial class PlaceClass
    {
        public long PlaceId { get; set; }

        public string Name { get; set; } = null!;

        public int CategoryId { get; set; }
        public string Categoria { get; set; } = null!;
        public int? CuisineId { get; set; }
        public string Tipo { get; set; } = null!;
        public int? PriceLevelId { get; set; }
        public string Precio { get; set; } = null!;
        public string? Emoji { get; set; }

        public string? Color { get; set; }

        public string? Description { get; set; }

        public decimal AverageRating { get; set; }

        public int ReviewCount { get; set; }

        public bool IsActive { get; set; }

        public bool IsVerified { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }

}
