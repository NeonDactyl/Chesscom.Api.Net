using Chesscom.Api.Net.Models;
using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class TitledPlayersEndpoint : BaseEndpoint<TitledPlayersReturn>
    {
        public TitledPlayersEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }
        public async Task<TitledPlayersReturn?> GetPlayersByTitleAsync(ChessTitle title)
        {
            string url = BaseUrl + "pub/titled/" + title.ToString();
            return await GetAsync(url);
        }
    }
}
