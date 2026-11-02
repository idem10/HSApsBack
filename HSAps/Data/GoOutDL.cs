using HSAps.Interfaces;
using HSAps.Models.HSAps;

namespace HSAps.Data
{
    public class GoOutDL : IGoOut
    {
        private readonly SparkRContext _spk = new SparkRContext();
        public List<Place> GetPlaces()
        {
            try
            {
                return _spk.Places.Where(x =>
                                x.IsActive == true
                                && x.IsVerified == true)
                                .ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<Category> GetCategorias()
        {
            try
            {
                return _spk.Categories.ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<Cuisine> GetTipos()
        {
            try
            {
                return _spk.Cuisines.ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<PriceLevel> GetPrecios()
        {
            try
            {
                return _spk.PriceLevels.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
