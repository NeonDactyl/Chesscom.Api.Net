using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class TournamentRoundGroupsEndpoint : BaseEndpoint<TournamentRoundGroupDetails>
    {
        public TournamentRoundGroupsEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<TournamentRoundGroupDetails?> GetTournamentRoundGroupDetailsByUrlAsync(string roundGroupUrl)
        {
            return await GetAsync(roundGroupUrl);
        }

        public async Task<TournamentRoundGroupDetails?> GetTournamentRoundGroupDetailsAsync(string tournamentId, int roundNumber, int groupNumber)
        {
            string url = $"{BaseUrl}pub/tournament/{tournamentId}/{roundNumber}/{groupNumber}";
            return await GetTournamentRoundGroupDetailsByUrlAsync(url);
        }
    }
}
