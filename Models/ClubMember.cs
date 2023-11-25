using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Chesscom.Api.Net.Models
{
    public class ClubMember
    {
        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("joined")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public long Joined { get; set; }
    }
}
