using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models
{
    public class ChesscomGameAccuracies
    {
        [JsonProperty("white")]
        public float White { get; set; }
        [JsonProperty("black")]
        public float Black { get; set; }
    }
}
