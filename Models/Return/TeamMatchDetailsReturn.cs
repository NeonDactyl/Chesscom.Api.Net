using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models.Return
{
    public class TeamMatchDetailsReturn
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartTime { get; set; }

        [JsonProperty("settings")]
        public TeamMatchSettings Settings { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("boards")]
        public int Boards { get; set; }

        [JsonProperty("teams")]
        public Dictionary<string, TeamMatchTeamDetails> Teams { get; set; }
    }

    public class TeamMatchSettings
    {
        [JsonProperty("time_class")]
        public string TimeClass { get; set; }

        [JsonProperty("time_control")]
        public string TimeControl { get; set; }

        [JsonProperty("rules")]
        public string Rules { get; set; }

        [JsonProperty("min_team_players")]
        public int MinTeamPlayers { get; set; }

        [JsonProperty("max_team_players")]
        public int MaxTeamPlayers { get; set; }

        [JsonProperty("min_required_games")]
        public int MinRequiredGames { get; set; }

        [JsonProperty("min_rating")]
        public int MinRating { get; set; }

        [JsonProperty("max_rating")]
        public int MaxRating { get; set; }

        [JsonProperty("autostart")]
        public bool Autostart { get; set; }
    }

    public class TeamMatchTeamDetails
    {
        [JsonProperty("@id")]
        public string ApiUrl { get; set; }

        [JsonProperty("url")]
        public string WebUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("players")]
        public List<TeamMatchPlayerDetails> Players { get; set; }

        [JsonProperty("fair_play_removals")]
        public List<string>? FairPlayRemovals { get; set; }
    }

    public class TeamMatchPlayerDetails
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("board")]
        public string BoardUrl { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("rd")]
        public double Rd { get; set; }

        [JsonProperty("timeout_percent")]
        public double TimeoutPercent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("stats")]
        public string StatsUrl { get; set; }

        [JsonProperty("played_as_white")]
        public string PlayedAsWhite { get; set; }

        [JsonProperty("played_as_black")]
        public string PlayedAsBlack { get; set; }
    }
}
