using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;

namespace Chesscom.Api.Net.Models.Return
{
    public class TimeControlStats
    {
        [JsonProperty("last")]
        public StatsLast Last { get; set; }
        [JsonProperty("best")]
        public StatsBestGame Best { get; set; }
        [JsonProperty("record")]
        public StatsRecord Record { get; set; }
        [JsonProperty("tournament")]
        public StatsTournament Tournament { get; set; }
    }

    public class StatsLast
    {
        [JsonProperty("date"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Date { get; set; }
        [JsonProperty("rating")]
        public int Rating { get; set; }
        [JsonProperty("rd")]
        public int Rd { get; set; }
    }
    public class StatsBest
    {
        [JsonProperty("date"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Date { get; set; }
        [JsonProperty("rating")]
        public int Rating { get; set; }
    }
    public class StatsBestGame : StatsBest
    {
        [JsonProperty("game")]
        public string Game { get; set; }
    }
    public class  StatsRecord
    {
        [JsonProperty("win")]
        public int Win { get; set; }
        [JsonProperty("loss")]
        public int Loss { get; set; }
        [JsonProperty("draw")]
        public int Draw { get; set; }
        [JsonProperty("time_per_move")]
        public int TimePerMove { get; set; }
        [JsonProperty("timeout_percent")]
        public float TimeoutPercent { get; set; }
    }
    public class StatsTournament
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("withdraw")]
        public int Withdraw { get; set; }
        [JsonProperty("points")]
        public int Points { get; set; }
        [JsonProperty("highest_finish")]
        public int HighestFinish { get; set; }
    }
    public class PuzzleRushStatsGroup
    {
        [JsonProperty("total_attempts")]
        public int TotalAttempts { get; set; }
        [JsonProperty("score")]
        public int Score { get; set; }
    }
    public class  PuzzleRushStats
    {
        [JsonProperty("daily")]
        public PuzzleRushStatsGroup Daily { get; set; }
        [JsonProperty("best")]
        public PuzzleRushStatsGroup Best { get; set; }
    }
    public class PuzzlesStats
    {
        [JsonProperty("highest")]
        public StatsBest Highest { get; set; }
        [JsonProperty("lowest")]
        public StatsBest Lowest{ get; set;}
    }
}
