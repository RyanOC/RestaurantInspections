using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using RI.Core.Contracts.Restaurant;

namespace RI.Data.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public RestaurantRepository()
        {
            // TODO: Inject TestingEntities for testing a mock
            // https://stackoverflow.com/questions/25960192/mocking-ef-dbcontext-with-moq
            // https://www.jankowskimichal.pl/en/2016/01/mocking-dbcontext-and-dbset-with-moq/
        }

        /// <summary>
        /// Gets a list of all restaurants
        /// </summary>
        /// <returns></returns>
        public List<RI.Core.Models.Restaurant> GetRestaurants()
        {
            using (TestingEntities db = new TestingEntities())
            {
                var rl = db.Restaurant.ToList();
                List <RI.Core.Models.Restaurant> restrauntModels = Mapper.Map<List<Restaurant>, List<RI.Core.Models.Restaurant>>(rl);
                return restrauntModels;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="licenseNumber"></param>
        /// <returns></returns>
        public RI.Core.Models.Restaurant GetRestaurantByLicenseNumber(string licenseNumber)
        {
            using (TestingEntities db = new TestingEntities())
            {
                var r = db.Restaurant.Where((x) => x.LicenceNumber == licenseNumber).FirstOrDefault();
                RI.Core.Models.Restaurant restrauntModel = Mapper.Map<Restaurant, RI.Core.Models.Restaurant>(r);
                return restrauntModel;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns></returns>
        public int InsertNewRestaurant(RI.Core.Models.Restaurant restaurant)
        {
            using (TestingEntities db = new TestingEntities())
            {
                Restaurant r = Mapper.Map<RI.Core.Models.Restaurant, Restaurant>(restaurant);
                db.Restaurant.Add(r);
                db.SaveChanges();
                return r.Id;
            }
        } 
    }
}
