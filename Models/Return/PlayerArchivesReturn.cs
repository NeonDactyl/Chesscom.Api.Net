using Newtonsoft.Json;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models.Return
{
    public class PlayerArchivesReturn
    {
        [JsonProperty("archives")]
        public List<string>? Archives { get; set; }
    }
}
