using Newtonsoft.Json;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models.Return
{
    public class PlayerCurrentDailyGamesReturn
    {
        [JsonProperty("games")]
        public List<PlayerDailyGame> Games { get; set; }
    }
}
