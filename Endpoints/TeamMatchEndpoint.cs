using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class TeamMatchEndpoint : BaseEndpoint<TeamMatchDetailsReturn>
    {
        public TeamMatchEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<TeamMatchDetailsReturn?> GetTeamMatchDetailsByMatchIdAsync(string matchId)
        {
            string url = $"{BaseUrl}pub/match/{matchId}";
            return await GetAsync(url);
        }
    }
}
