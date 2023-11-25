using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace Chesscom.Api.Net.Models.Return
{
    public class TournamentRoundGroupDetails
    {
        [JsonProperty("fair_play_removals")]
        public List<string>? FairPlayRemovals { get; set; }

        [JsonProperty("games")]
        public List<TournamentRoundGroupGame>? Games { get; set; }

        [JsonProperty("players")]
        public List<TournamentRoundGroupPlayer>? Players { get; set; }
    }

    public class TournamentRoundGroupGame
    {
        [JsonProperty("white")]
        public string? White { get; set; }

        [JsonProperty("black")]
        public string? Black { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("fen")]
        public string? Fen { get; set; }

        [JsonProperty("pgn")]
        public string? Pgn { get; set; }

        [JsonProperty("turn")]
        public string? Turn { get; set; }

        [JsonProperty("move_by")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public long MoveBy { get; set; }

        [JsonProperty("draw_offer")]
        public string? DrawOffer { get; set; }

        [JsonProperty("last_activity")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public long LastActivity { get; set; }

        [JsonProperty("start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public long StartTime { get; set; }

        [JsonProperty("time_control")]
        public string? TimeControl { get; set; }

        [JsonProperty("time_class")]
        public string? TimeClass { get; set; }

        [JsonProperty("rules")]
        public string? Rules { get; set; }

        [JsonProperty("eco")]
        public string? Eco { get; set; }

        [JsonProperty("tournament")]
        public string? Tournament { get; set; }
    }

    public class TournamentRoundGroupPlayer
    {
        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("tie_break")]
        public int TieBreak { get; set; }

        [JsonProperty("is_advancing")]
        public bool IsAdvancing { get; set; }
    }
}
