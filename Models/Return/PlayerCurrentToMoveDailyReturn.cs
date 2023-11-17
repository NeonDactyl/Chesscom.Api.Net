using Newtonsoft.Json;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models.Return
{
    public class PlayerCurrentToMoveDailyReturn
    {
        [JsonProperty("games")]
        public List<PlayerToMoveDailyGame> Games { get; set; }
    }
}
