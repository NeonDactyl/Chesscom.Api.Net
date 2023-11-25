using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class TournamentRoundsEndpoint : BaseEndpoint<TournamentRoundReturn>
    {
        public TournamentRoundsEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<TournamentRoundReturn?> GetTournamentRoundReturnByUrlAsync(string roundUrl)
        {
            return await GetAsync(roundUrl);
        }

        public async Task<TournamentRoundReturn?> GetTournamentRoundReturnAsync(string tournamentId, int roundNumber)
        {
            string url = $"{BaseUrl}pub/tournament/{tournamentId}/{roundNumber}";
            return await GetTournamentRoundReturnByUrlAsync(url);
        }
    }
}
