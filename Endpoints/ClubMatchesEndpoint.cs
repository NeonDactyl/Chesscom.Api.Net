using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class ClubMatchesEndpoint : BaseEndpoint<ClubMatchesReturn>
    {
        public ClubMatchesEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<ClubMatchesReturn?> GetClubMatchesAsync(string clubId)
        {
            string url = $"{BaseUrl}pub/club/{clubId}/matches";
            return await GetAsync(url);
        }
    }
}
