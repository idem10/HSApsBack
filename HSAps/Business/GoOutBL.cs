using HSAps.Interfaces;
using HSAps.Models;
using HSAps.Models.HSAps;

namespace HSAps.Business
{
    public class GoOutBL
    {
        private readonly IGoOut _go;
        public GoOutBL(IGoOut go) => _go = go;
        public List<PlaceClass> GetGoOut()
        {
            List<PlaceClass> pc = new List<PlaceClass>();
            try
            {
                var places = _go.GetPlaces();
                var categorias = _go.GetCategorias();
                var tipos = _go.GetTipos();
                var precios = _go.GetPrecios();
                var locations = _go.GetPlaceLocations();
                var imagenes = _go.GetPlacePhotos();
                places.ForEach(x =>
                {
                    pc.Add(new PlaceClass
                    {
                        PlaceId = x.PlaceId,
                        Name = x.Name,
                        CategoryId = x.CategoryId,
                        Categoria = categorias.Count > 0 ? categorias.Where(c => c.CategoryId == x.CategoryId).FirstOrDefault()?.Name : "",
                        CuisineId = x.CuisineId,
                        Tipo = tipos.Count > 0 ? tipos.Where(t => t.CuisineId == x.CategoryId).FirstOrDefault()?.Name : "",
                        PriceLevelId = x.PriceLevelId,
                        Precio = precios.Count > 0 ? precios.Where(p => p.PriceLevelId == x.PriceLevelId).FirstOrDefault()?.Name : "",
                        Emoji = x.Emoji,
                        Color = x.Color,
                        Description = x.Description,
                        AverageRating = x.AverageRating,
                        ReviewCount = x.ReviewCount,
                        IsActive = x.IsActive,
                        IsVerified = x.IsVerified,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        Latitude = (decimal)(locations.Count > 0 ? locations.Where(l => l.PlaceId == x.PlaceId).FirstOrDefault()?.Latitude : 0),
                        Longitude = (decimal)(locations.Count > 0 ? locations.Where(l => l.PlaceId == x.PlaceId).FirstOrDefault()?.Longitude : 0),
                        ImageUrl = imagenes.Count > 0 ? imagenes.Where(i => i.PlaceId == x.PlaceId).FirstOrDefault()?.ImageUrl : ""
                    });
                });
                return pc;
            }
            catch
            {
                throw;
            }
        }
    }
}
