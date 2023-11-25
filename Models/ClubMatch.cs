using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models
{
    public class ClubMatch
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("@id")]
        public string? AtId { get; set; }

        [JsonProperty("opponent")]
        public string? Opponent { get; set; }

        [JsonProperty("result")]
        public string? Result { get; set; }

        [JsonProperty("start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartTime { get; set; }

        [JsonProperty("time_class")]
        public string? TimeClass { get; set; }
    }
}
