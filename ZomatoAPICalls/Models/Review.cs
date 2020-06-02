using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZomatoAPICall.Models
{
    public class Review
    {
        [JsonProperty("rating")]
        public string Rating { get; set; }
        [JsonProperty("review_time_friendly")]
        public string RatingAge { get; set; }

        [JsonProperty("user")]
        public User Visitor { get; set; }

    }
}
