using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerCurrentToMoveDailyGamesEndpoint : BaseEndpoint<PlayerCurrentToMoveDailyReturn>
    {
        public PlayerCurrentToMoveDailyGamesEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<PlayerCurrentToMoveDailyReturn?> GetCurrentToMoveDailyByUsername(string username)
        {
            string url = BaseUrl + "pub/player/" + username + "/to-move";
            return await GetAsync(url);
        }
    }
}
