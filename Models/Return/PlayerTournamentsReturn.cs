using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chesscom.Api.Net.Models.Return
{
    public class PlayerTournamentsReturn
    {
        [JsonProperty("finished")]
        public List<FinishedTournament>? Finished { get; set; }

        [JsonProperty("in_progress")]
        public List<InProgressTournament>? InProgress { get; set; }

        [JsonProperty("registered")]
        public List<RegisteredTournament>? Registered { get; set; }
    }
}
