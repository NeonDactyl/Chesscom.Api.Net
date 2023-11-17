using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerCurrentDailyGamesEndpoint : BaseEndpoint<PlayerCurrentDailyGamesReturn>
    {
        public PlayerCurrentDailyGamesEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<PlayerCurrentDailyGamesReturn?> GetPlayerCurrentDailyGamesByUsernameAsync(string username)
        {
            string url = BaseUrl + "pub/player/" + username + "/games";
            return await GetAsync(url);
        }
    }
}
