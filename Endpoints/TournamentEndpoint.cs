using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class TournamentEndpoint : BaseEndpoint<TournamentReturn>
    {
        public TournamentEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<TournamentReturn?> GetTournamentDetailsAsync(string urlId)
        {
            string url = $"{BaseUrl}pub/tournament/{urlId}";
            return await GetAsync(url);
        }
    }
}
