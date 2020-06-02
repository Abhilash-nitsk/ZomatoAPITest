using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZomatoAPICalls.Models;

namespace ZomatoAPICalls.Service
{
    class ZomatoEntry
    {
        

        public static void ShowRestaurants()
        {
            var response = ZomatoInfo.GetRestaurants();

            var restaurants = response.Restaurants;

            Console.WriteLine($"Results found : {response.ResultsFound}");
            Console.WriteLine($"Results shown : {response.ResultsShown}");
            Console.WriteLine();

            Console.WriteLine($"{"ID",-10} {"NAME",-40} {"CUISINES",-50} {"LOCATION",-40}");
            foreach (var r in restaurants)
            {
                var restaurant = r.Restaurant;

                Console.WriteLine($"{restaurant.ID,-10} {restaurant.Name,-40} {restaurant.Cuisines,-50} {restaurant.Location.LocalityVerbose,-40}");
            }

            Console.ReadLine();
        }
    }
}
