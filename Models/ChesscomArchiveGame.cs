using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Chesscom.Api.Net.Models
{
    public class ChesscomArchiveGame : ChesscomArchiveGameBase
    {
        [JsonProperty("white")]
        public ChesscomGamePlayer White { get; set; }
        [JsonProperty("black")]
        public ChesscomGamePlayer Black { get; set; }
        [JsonProperty("accuracies")]
        public ChesscomGameAccuracies Accuracies { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("fen")]
        public string FEN { get; set; }
        [JsonProperty("start_time"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartTime { get; set; }
        [JsonProperty("end_time"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EndTime { get; set; }
        [JsonProperty("eco")]
        public string Eco { get; set; }
        [JsonProperty("tournament")]
        public string Tournament { get; set; }
        [JsonProperty("match")]
        public string Match { get; set; }


    }
}
