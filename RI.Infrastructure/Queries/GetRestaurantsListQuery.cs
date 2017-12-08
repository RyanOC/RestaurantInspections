using System.Collections.Generic;
using RI.Core.Contracts.Restaurant;
using RI.Core.Contracts.Restaurant.Query;

namespace RI.Infrastructure.Queries
{
    public class GetRestaurantsListQuery : IGetRestaurantsListQuery
    {
        IRestaurantRepository _repo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        public GetRestaurantsListQuery(IRestaurantRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<RI.Core.Models.Restaurant> Execute()
        {
            return _repo.GetRestaurants();
        }
    }
}
