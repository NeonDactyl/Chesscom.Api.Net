using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerStatsEndpoint : BaseEndpoint<PlayerStatsReturn>
    {
        public PlayerStatsEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }
        public async Task<PlayerStatsReturn?> GetPlayerStatsByUsernameAsync(string username)
        {
            string url = BaseUrl + "pub/player/" + username + "/stats";
            return await GetAsync(url);
        }
    }
}
