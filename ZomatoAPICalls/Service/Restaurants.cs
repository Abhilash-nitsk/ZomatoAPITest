using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZomatoAPICalls.Models;

namespace ZomatoAPICalls.Service
{
    class Restaurants
    {
        public static void ShowRestaurants()
        {
            var response = ZomatoInfo.GetRestaurants();

            var restaurants = response.Restaurants;

            Console.WriteLine($"Results found : {response.ResultsFound}");
            Console.WriteLine($"Results shown : {response.ResultsShown}");
            Console.WriteLine();

            Console.WriteLine($"{"ID",-10} {"NAME",-50} {"CUISINES",-60} {"LOCATION",-40}");
            foreach (var r in restaurants)
            {
                var restaurant = r.Restaurant;

                Console.WriteLine($"{restaurant.ID,-10} {restaurant.Name,-50} {restaurant.Cuisines,-60} {restaurant.Location.LocalityVerbose,-40}");
            }

            Console.ReadLine();
        }
    }
}
