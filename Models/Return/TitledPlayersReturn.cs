using Newtonsoft.Json;

namespace Chesscom.Api.Net.Models.Return
{
    public class TitledPlayersReturn
    {
        [JsonProperty("players")]
        public string[]? Players { get; set; }
    }
}
