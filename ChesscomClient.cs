using Chesscom.Api.Net.Endpoints;
using Chesscom.Api.Net.Models;
using Chesscom.Api.Net.Models.Return;
using System.Threading.Tasks;

namespace Chesscom.Api.Net
{
    public class ChesscomClient
    {
        public static string DefaultUserAgent = "Anonymous User";
        private string UserAgent;
        private PlayerProfileEndpoint PlayerProfileEndpoint;
        private TitledPlayersEndpoint TitledPlayersEndpoint;
        private PlayerStatsEndpoint PlayerStatsEndpoint;
        private PlayerOnlineEndpoint PlayerOnlineEndpoint;
        private PlayerCurrentDailyGamesEndpoint PlayerCurrentDailyGamesEndpoint;
        private PlayerCurrentToMoveDailyGamesEndpoint PlayerCurrentToMoveDailyGamesEndpoint;
        private PlayerArchivesEndpoint PlayerArchivesEndpoint;
        private PlayerMonthArchiveEndpoint PlayerMonthArchiveEndpoint;

        public ChesscomClient(string? defaultUserAgent = null)
        {
            UserAgent = defaultUserAgent ?? ChesscomClient.DefaultUserAgent;

            PlayerProfileEndpoint = new PlayerProfileEndpoint(UserAgent);
            TitledPlayersEndpoint = new TitledPlayersEndpoint(UserAgent);
            PlayerStatsEndpoint = new PlayerStatsEndpoint(UserAgent);
            PlayerOnlineEndpoint = new PlayerOnlineEndpoint(UserAgent);
            PlayerCurrentDailyGamesEndpoint = new PlayerCurrentDailyGamesEndpoint(UserAgent);
            PlayerCurrentToMoveDailyGamesEndpoint = new PlayerCurrentToMoveDailyGamesEndpoint(UserAgent);
            PlayerArchivesEndpoint = new PlayerArchivesEndpoint(UserAgent);
            PlayerMonthArchiveEndpoint = new PlayerMonthArchiveEndpoint(UserAgent);
        }

        public async Task<PlayerProfileReturn?> GetPlayerProfileByUsernameAsync(string username)
        {
            return await PlayerProfileEndpoint.GetPlayerProfileByUsernameAsync(username);
        }
        public async Task<TitledPlayersReturn?> GetPlayersByTitleAsync(ChessTitle title)
        {
            return await TitledPlayersEndpoint.GetPlayersByTitleAsync(title);
        }
        public async Task<PlayerStatsReturn?> GetPlayerStatsByUsernameAsync(string username)
        {
            return await PlayerStatsEndpoint.GetPlayerStatsByUsernameAsync(username);
        }
        public async Task<PlayerOnlineReturn?> GetIsPlayerOnlineByUsernameAsync(string username)
        {
            return await PlayerOnlineEndpoint.GetIsPlayerOnlineByUsernameAsync(username);
        }
        public async Task<PlayerCurrentToMoveDailyReturn?> GetCurrentToMoveDailyByUsername(string username)
        {
            return await PlayerCurrentToMoveDailyGamesEndpoint.GetCurrentToMoveDailyByUsername(username);
        }
        public async Task<PlayerCurrentDailyGamesReturn?> GetPlayerCurrentDailyGamesByUsernameAsync(string username)
        {
            return await PlayerCurrentDailyGamesEndpoint.GetPlayerCurrentDailyGamesByUsernameAsync(username);
        }
        public async Task<PlayerArchivesReturn?> GetPlayerArchivesByUsernameAsync(string username)
        {
            return await PlayerArchivesEndpoint.GetPlayerArchivesByUsernameAsync(username);
        }
        public async Task<PlayerMonthArchiveReturn?> GetPlayerMonthArchiveByUrlAsync(string url)
        {
            return await PlayerMonthArchiveEndpoint.GetPlayerMonthArchiveByUrlAsync(url);
        }
        public async Task<PlayerMonthArchiveReturn?> GetPlayerMonthArchiveByUsernameYearMonthAsync(string username, int year, int month)
        {
            return await PlayerMonthArchiveEndpoint.GetPlayerMonthArchiveByUsernameYearMonthAsync(username, year, month);
        }
    }
}
