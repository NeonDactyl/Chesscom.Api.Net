using Chesscom.Api.Net.Models.Return;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerClubsEndpoint : BaseEndpoint<PlayerClubsReturn>
    {
        public PlayerClubsEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<PlayerClubsReturn?> GetPlayerClubsByUsernameAsync(string username)
        {
            string url = BaseUrl + "pub/player/" + username + "/clubs";
            return await GetAsync(url);
        }
    }
}
