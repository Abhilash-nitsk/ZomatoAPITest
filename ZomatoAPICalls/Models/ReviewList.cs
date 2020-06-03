using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZomatoAPICalls.Models
{
    public class ReviewList
    {
        [JsonProperty("reviews_count")]
        public int ReviewCount { get; set; }

        [JsonProperty("reviews_shown")]
        public int ReviewShown { get; set; }

        [JsonProperty("user_reviews")]
        public ReviewRecord[] Reviews{ get; set; }

    }
}
