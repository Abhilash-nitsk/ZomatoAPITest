using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ZomatoAPICall.Models
{
    public class ReviewRecord
    {
        [JsonProperty("review")]
        public Review Review { get; set; }
    }
}
