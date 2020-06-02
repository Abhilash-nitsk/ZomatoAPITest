using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZomatoAPICall.Models;
using ZomatoAPICalls.Models;

namespace ZomatoAPICalls.Service
{
    class Reviews
    {
        public static void ShowReviews()
        {
            var response = ZomatoInfo.GetReviews();

            var reviews = response.Reviews;

            Console.WriteLine($"Reviews found : {response.ReviewCount}");
            Console.WriteLine($"Reviews shown : {response.ReviewShown}");
            Console.WriteLine();

            Console.WriteLine($"{"Rating",-10} {"Rating Age",-50} {"Name",-60}");
            foreach (var r in reviews)
            {
                var review = r.Review;
                Console.WriteLine($"{review.Rating,-10} {review.RatingAge,-50} {review.Visitor.Name,-60}");
            }

            Console.ReadLine();
        }
    }
}
