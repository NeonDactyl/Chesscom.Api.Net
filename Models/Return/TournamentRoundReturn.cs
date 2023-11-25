using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models.Return
{
    public class TournamentRoundReturn
    {
        [JsonProperty("groups")]
        public List<string>? Groups { get; set; }
        [JsonProperty("players")]
        public List<TournamentRoundPlayer>? Players { get; set; }
    }
    public class TournamentRoundPlayer
    {
        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("is_advancing")]
        public bool IsAdvancing { get; set; }
    }
}
