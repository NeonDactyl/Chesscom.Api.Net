using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models
{
    public class PlayerToMoveDailyGame : ChesscomGameBase
    {
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("move_by"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime MoveBy { get; set; }
        [JsonProperty("draw_offer")]
        public string? DrawOffer { get; set; }
    }
}
