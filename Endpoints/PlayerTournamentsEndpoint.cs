using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerTournamentsEndpoint : BaseEndpoint<PlayerTournamentsReturn>
    {
        public PlayerTournamentsEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<PlayerTournamentsReturn?> GetPlayerTournamentsByUsernameAsync(string username)
        {
            string url = $"{BaseUrl}pub/player/{username}/tournaments";
            return await GetAsync(url);
        }
    }
}
