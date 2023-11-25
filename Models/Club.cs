using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models
{
    public class Club
    {
        [JsonProperty("@id")]
        public string? Id { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("last_activity"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? LastActivity { get; set; }
        [JsonProperty("icon")]
        public string? Icon { get; set; }
        [JsonProperty("url")]
        public string? Url { get; set; }
        [JsonProperty("joined"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Joined { get; set; }

        public override string ToString()
        {
            return $"Chess.com club - {this.Name}";
        }
    }
}
