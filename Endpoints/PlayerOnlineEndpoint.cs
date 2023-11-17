using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerOnlineEndpoint : BaseEndpoint<PlayerOnlineReturn>
    {
        public PlayerOnlineEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }
        public async Task<PlayerOnlineReturn?> GetIsPlayerOnlineByUsernameAsync(string username)
        {
            string url = BaseUrl + "pub/player/" + username + "/is-online";
            return await GetAsync(url);
        }
    }
}
