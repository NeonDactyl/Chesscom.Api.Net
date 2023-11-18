using Chesscom.Api.Net.Models.Return;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chesscom.Api.Net.Endpoints
{
    internal class PlayerMonthArchivePgnEndpoint : BaseEndpoint<string>
    {
        public PlayerMonthArchivePgnEndpoint(string? defaultUserAgent = null) : base(defaultUserAgent) { }
        public async Task<string?>  GetPlayerMonthlyArchivePgnByUrlAsync(string url, string? filePath = null)
        {
            return await GetFileAsync(url, filePath);
        }
        public async Task<string?> GetPlayerMonthlyArchivePgnByArchiveUrlAsync(string archiveUrl, string? filePath = null)
        {
            return await GetFileAsync(archiveUrl + "/pgn", filePath);
        }
        public async Task<string?> GetPlayerMonthArchivePgnByUsernameYearMonthAsync(string username, int year, int month, string? filePath)
        {
            if (year > DateTime.Now.Year || year < 1970 || month > 12 || month < 0 || (year == DateTime.Now.Year && month > DateTime.Now.Month))
            {
                throw new ArgumentException();
            }
            string url = $"{BaseUrl}pub/player/{username}/games/{year.ToString().PadLeft(4, '0')}/{month.ToString().PadLeft(2, '0')}";
            return await GetPlayerMonthlyArchivePgnByArchiveUrlAsync(url, filePath);
        }
    }
}
