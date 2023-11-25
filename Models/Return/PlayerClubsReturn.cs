using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models.Return
{
    public class PlayerClubsReturn
    {
        [JsonProperty("clubs")]
        List<Club>? Clubs { get; set; }
    }
}
