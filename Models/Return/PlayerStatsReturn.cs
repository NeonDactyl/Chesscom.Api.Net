using Newtonsoft.Json;

namespace Chesscom.Api.Net.Models.Return
{
    public class PlayerStatsReturn
    {
        [JsonProperty("chess_daily")]
        public TimeControlStats? ChessDaily { get; set; }
        [JsonProperty("chess_bullet")]
        public TimeControlStats? ChessBullet { get; set; }
        [JsonProperty("chess_blitz")]
        public TimeControlStats? ChessBlitz { get; set; }
        [JsonProperty("chess_rapid")]
        public TimeControlStats? ChessRapid { get; set; }
        [JsonProperty("chess960_daily")]
        public TimeControlStats? Chess960Daily { get; set; }
        [JsonProperty("chess960_bullet")]
        public TimeControlStats? Chess960Bullet { get; set; }
        [JsonProperty("chess960_blitz")]
        public TimeControlStats? Chess960Blitz { get; set; }
        [JsonProperty("chess960_rapid")]
        public TimeControlStats? Chess960Rapid { get; set; }
        [JsonProperty("tactics")]
        public PuzzlesStats? Tactics { get; set; }
        [JsonProperty("lessons")]
        public PuzzlesStats? Lessons { get; set; }
        [JsonProperty("puzzle_rush")]
        public PuzzleRushStats? PuzzleRush { get; set; }
    }
}
