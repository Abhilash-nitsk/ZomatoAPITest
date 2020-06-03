using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZomatoAPICalls.Models;

namespace ZomatoAPICalls.Contracts
{
    public interface IZomatoInfo
    {
        /// <summary>
        /// Calls the GetRestaurants service method to get all Restaurants for a location.
        /// </summary>
        /// <returns>The order details.</returns>
        RestaurantList GetRestaurants();


        /// <summary>
        /// Calls the GetRestaurants service method to get all Restaurants for a location.
        /// </summary>
        /// <returns>The order details.</returns>
        ReviewList GetReviews();
    }
}
