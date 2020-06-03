using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZomatoAPICalls.Models;
using ZomatoAPICalls.Contracts;

namespace ZomatoAPICalls.Service
{
    public class ZomatoInfo : IZomatoInfo
    {
        const string URL = "https://developers.zomato.com/api/v2.1/";
        const string APIKEY = "8f0ecb20c010ce8a9ce710255369069f";
        const string CITYID = "6";
        const string RESTAURANTID = "90903";

        public  RestaurantList GetRestaurants()
        {
            string urlParameters = $"search?entity_id={CITYID}&entity_type=city&apikey={APIKEY}";
            var response = APICall.RunAsync<RestaurantList>(URL, urlParameters).GetAwaiter().GetResult();
            return response;
        }

        public ReviewList GetReviews()
        {
            //https://developers.zomato.com/api/v2.1/reviews?res_id=90903
            string urlParameters = $"reviews?res_id={RESTAURANTID}&apikey={APIKEY}";
            var response = APICall.RunAsync<ReviewList>(URL, urlParameters).GetAwaiter().GetResult();
            return response;
        }
    }
}
