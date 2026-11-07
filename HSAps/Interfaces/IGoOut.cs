using HSAps.Models.HSAps;

namespace HSAps.Interfaces
{
    public interface IGoOut
    {
        List<Place> GetPlaces();
        List<Category> GetCategorias();
        List<Cuisine> GetTipos();
        List<PriceLevel> GetPrecios();
        List<PlaceLocation> GetPlaceLocations();
        List<PlacePhoto> GetPlacePhotos();
        User GetUser(User u);
    }
}
