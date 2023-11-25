using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class ClubMembersEndpoint : BaseEndpoint<ClubMembersReturn>
    {
        public ClubMembersEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }

        public async Task<ClubMembersReturn?> GetClubMembersActivityAsync(string urlId)
        {
            string url = $"{BaseUrl}pub/club/{urlId}/members";
            return await GetAsync(url);
        }
    }
}
