using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models.Return
{
    public class PlayerMonthArchiveReturn
    {
        [JsonProperty("games")]
        public List<ChesscomArchiveGame> Games { get; set; }
    }
}
