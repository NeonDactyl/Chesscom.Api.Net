using Chesscom.Api.Net.Models.Return;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerMonthArchiveEndpoint : BaseEndpoint<PlayerMonthArchiveReturn>
    {
        public PlayerMonthArchiveEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }
        public async Task<PlayerMonthArchiveReturn?> GetPlayerMonthArchiveByUrlAsync(string url)
        {
            return await GetAsync(url);
        }
        public async Task<PlayerMonthArchiveReturn?> GetPlayerMonthArchiveByUsernameYearMonthAsync(string username, int year, int month)
        {
            if (year > DateTime.Now.Year || year < 1970 || month > 12 || month < 0 || (year == DateTime.Now.Year && month > DateTime.Now.Month))
            {
                throw new ArgumentException();
            }
            string url = $"{BaseUrl}pub/player/{username}/games/{year.ToString().PadLeft(4, '0')}/{month.ToString().PadLeft(2, '0')}";
            return await GetAsync(url);
        }
    }
}
