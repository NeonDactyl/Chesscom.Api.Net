using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models
{
    public class PlayerDailyGame : PlayerToMoveDailyGame
    {
        [JsonProperty("white")]
        public string White { get; set; }
        [JsonProperty("black")]
        public string Black { get; set; }
        [JsonProperty("turn")]
        public string Turn { get; set; }
        [JsonProperty("start_time"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartTime{ get; set; }

        [JsonProperty("match")]
        public string Match { get; set; }
    }
}
