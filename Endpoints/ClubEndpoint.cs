using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class ClubEndpoint : BaseEndpoint<ClubReturn>
    {
        public ClubEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<ClubReturn?> GetClubProfileAsync(string urlId)
        {
            string url = $"{BaseUrl}pub/club/{urlId}";
            return await GetAsync(url);
        }
    }
}
