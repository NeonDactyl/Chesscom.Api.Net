using Newtonsoft.Json;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models
{
    public class Tournament
    {
        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("@id")]
        public string? Id { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }

    public class FinishedTournament : Tournament
    {
        [JsonProperty("wins")]
        public int? Wins { get; set; }

        [JsonProperty("losses")]
        public int? Losses { get; set; }

        [JsonProperty("draws")]
        public int? Draws { get; set; }

        [JsonProperty("points_awarded")]
        public int? PointsAwarded { get; set; }

        [JsonProperty("placement")]
        public int? Placement { get; set; }

        [JsonProperty("total_players")]
        public int? TotalPlayers { get; set; }
    }

    public class InProgressTournament : Tournament { }

    public class RegisteredTournament : Tournament { }
}
