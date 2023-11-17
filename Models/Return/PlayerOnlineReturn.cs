using Newtonsoft.Json;

namespace Chesscom.Api.Net.Models.Return
{
    public class PlayerOnlineReturn
    {
        [JsonProperty("online")]
        public bool Online { get; set; }
    }
}
