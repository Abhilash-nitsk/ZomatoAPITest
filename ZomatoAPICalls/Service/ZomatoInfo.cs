using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZomatoAPICalls.Models;

namespace ZomatoAPICalls.Service
{
    public static class ZomatoInfo
    {
        const string url = "https://developers.zomato.com/api/v2.1/";
        const string apiKey = "8f0ecb20c010ce8a9ce710255369069f";

        public static RestaurantList GetRestaurants()
        {
            string urlParameters = $"search?entity_id=6&entity_type=city&apikey={apiKey}";
            var response = APICall.RunAsync<RestaurantList>(url, urlParameters).GetAwaiter().GetResult();
            return response;
        }
    }
}
