using Newtonsoft.Json;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models.Return
{
    public class ClubReturn
    {
        [JsonProperty("@id")]
        public string? AtId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("club_id")]
        public int ClubId { get; set; }

        [JsonProperty("icon")]
        public string? Icon { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("average_daily_rating")]
        public int AverageDailyRating { get; set; }

        [JsonProperty("members_count")]
        public int MembersCount { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("last_activity")]
        public long LastActivity { get; set; }

        [JsonProperty("visibility")]
        public string? Visibility { get; set; }

        [JsonProperty("join_request")]
        public string? JoinRequest { get; set; }

        [JsonProperty("admin")]
        public List<string>? Admin { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
