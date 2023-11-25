using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models.Return
{
    public class ClubMatchesReturn
    {
        [JsonProperty("finished")]
        public List<ClubMatch>? Finished { get; set; }
        [JsonProperty("in_progress")]
        public List<ClubMatch>? InProgress { get; set; }
        [JsonProperty("registered")]
        public List<ClubMatch>? Registered { get; set; }
    }
}
