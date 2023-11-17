using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models
{
    public class ChesscomArchiveGameBase
    {
        [JsonProperty("pgn")]
        public string PGN { get; set; }
        [JsonProperty("rules")]
        public string Rules { get; set; }
        [JsonProperty("time_control")]
        public string TimeControl { get; set; }
    }
}
