using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models
{
    public class ChesscomGameBase : ChesscomArchiveGameBase
    {
        [JsonProperty("time_class")]
        public string TimeClass { get; set; }
        [JsonProperty("last_activity"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime LastActivity { get; set; }
    }
}
