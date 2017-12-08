using System.Collections.Generic;

namespace RI.Core.Contracts.Restaurant
{
    public interface IRestaurantRepository
    {
        List<Models.Restaurant> GetRestaurants();
        Models.Restaurant GetRestaurantByLicenseNumber(string licenseNumber);
        int InsertNewRestaurant(Models.Restaurant restaurant);
    }
}