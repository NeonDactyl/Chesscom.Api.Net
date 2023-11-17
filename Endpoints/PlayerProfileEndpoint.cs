using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerProfileEndpoint : BaseEndpoint<PlayerProfileReturn>
    {
        public PlayerProfileEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<PlayerProfileReturn?> GetPlayerProfileByUsernameAsync(string username)
        {
            string url = BaseUrl + "pub/player/" + username;
            return await GetAsync(url);
        }
    }
}
