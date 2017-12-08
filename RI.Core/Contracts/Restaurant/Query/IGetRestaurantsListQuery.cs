using System.Collections.Generic;

namespace RI.Core.Contracts.Restaurant.Query
{
    public interface IGetRestaurantsListQuery
    {
        List<Models.Restaurant> Execute();
    }
}
