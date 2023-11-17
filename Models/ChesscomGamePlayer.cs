using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models
{
    public class ChesscomGamePlayer
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("rating")]
        public int Rating { get; set; }
        [JsonProperty("result")]
        public string Result { get; set; }
        [JsonProperty("@id")]
        public string Id { get; set; }
    }
}
