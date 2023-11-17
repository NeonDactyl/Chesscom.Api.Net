using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerArchivesEndpoint : BaseEndpoint<PlayerArchivesReturn>
    {
        public PlayerArchivesEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }
        public async Task<PlayerArchivesReturn?> GetPlayerArchivesByUsernameAsync(string username)
        {
            string url = BaseUrl + "pub/player/" + username + "/games/archives";
            return await GetAsync(url);
        }
    }
}
