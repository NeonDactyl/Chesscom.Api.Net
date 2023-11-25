using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models.Return
{
    public class ClubMembersReturn
    {
        [JsonProperty("weekly")]
        public List<ClubMember>? Weekly { get; set; }
        [JsonProperty("monthly")]
        public List<ClubMember>? Monthly { get; set; }
        [JsonProperty("all_time")]
        public List<ClubMember>? AllTime { get; set; }
    }
}
