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
                places.ForEach(x =>
                {
                    pc.Add(new PlaceClass
                    {
                        PlaceId = x.PlaceId,
                        Name = x.Name,
                        CategoryId = x.CategoryId,
                        Categoria = "",
                        CuisineId = x.CuisineId,
                        Tipo = "",
                        PriceLevelId = x.PriceLevelId,
                        Precio = "",
                        Emoji = x.Emoji,
                        Color = x.Color,
                        Description = x.Description,
                        AverageRating = x.AverageRating,
                        ReviewCount = x.ReviewCount,
                        IsActive = x.IsActive,
                        IsVerified = x.IsVerified,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
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
