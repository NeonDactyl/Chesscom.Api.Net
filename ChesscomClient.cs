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
        private PlayerMonthArchivePgnEndpoint PlayerMonthArchivePgnEndpoint;
        private PlayerClubsEndpoint PlayerClubsEndpoint;
        private PlayerTournamentsEndpoint PlayerTournamentsEndpoint;
        private ClubEndpoint ClubEndpoint;
        private ClubMembersEndpoint ClubMembersEndpoint;
        private ClubMatchesEndpoint ClubMatchesEndpoint;
        private TournamentEndpoint TournamentEndpoint;
        private TournamentRoundsEndpoint TournamentRoundsEndpoint;
        private TournamentRoundGroupsEndpoint TournamentRoundGroupsEndpoint;

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
            PlayerMonthArchivePgnEndpoint = new PlayerMonthArchivePgnEndpoint(UserAgent);
            PlayerClubsEndpoint = new PlayerClubsEndpoint(UserAgent);
            PlayerTournamentsEndpoint = new PlayerTournamentsEndpoint(UserAgent);
            ClubEndpoint = new ClubEndpoint(UserAgent);
            ClubMembersEndpoint = new ClubMembersEndpoint(UserAgent);
            ClubMatchesEndpoint = new ClubMatchesEndpoint(UserAgent);
            TournamentEndpoint = new TournamentEndpoint(UserAgent);
            TournamentRoundsEndpoint = new TournamentRoundsEndpoint(UserAgent);
            TournamentRoundGroupsEndpoint = new TournamentRoundGroupsEndpoint(UserAgent);
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
        public async Task<string?> GetPlayerMonthlyArchivePgnByUrlAsync(string url, string? filePath = null)
        {
            return await PlayerMonthArchivePgnEndpoint.GetPlayerMonthlyArchivePgnByUrlAsync(url, filePath);
        }
        public async Task<string?> GetPlayerMonthlyArchivePgnByArchiveUrlAsync(string archiveUrl, string? filePath = null)
        {
            return await PlayerMonthArchivePgnEndpoint.GetPlayerMonthlyArchivePgnByArchiveUrlAsync(archiveUrl, filePath);
        }
        public async Task<string?> GetPlayerMonthArchivePgnByUsernameYearMonthAsync(string username, int year, int month, string? filePath)
        {
            return await PlayerMonthArchivePgnEndpoint.GetPlayerMonthArchivePgnByUsernameYearMonthAsync(username, year, month, filePath);
        }
        public async Task<PlayerClubsReturn?> GetPlayerClubsByUsernameAsync(string username)
        {
            return await PlayerClubsEndpoint.GetPlayerClubsByUsernameAsync(username);
        }
        public async Task<PlayerTournamentsReturn?> GetPlayerTournamentsByUsernameAsync(string username)
        {
            return await PlayerTournamentsEndpoint.GetPlayerTournamentsByUsernameAsync(username);
        }
        public async Task<ClubReturn?> GetClubProfileAsync(string urlId)
        {
            return await ClubEndpoint.GetClubProfileAsync(urlId);

        }
        public async Task<ClubMembersReturn?> GetClubMembersActivityAsync(string urlId)
        {
            return await ClubMembersEndpoint.GetClubMembersActivityAsync(urlId);
        }
        public async Task<ClubMatchesReturn?> GetClubMatchesAsync(string urlId)
        {
            return await ClubMatchesEndpoint.GetClubMatchesAsync(urlId);
        }
        public async Task<TournamentReturn?> GetTournamentDetailsAsync(string urlId)
        {
            return await TournamentEndpoint.GetTournamentDetailsAsync(urlId);
        }
        public async Task<TournamentRoundReturn?> GetTournamentRoundAsync(string roundUrl)
        {
            return await TournamentRoundsEndpoint.GetTournamentRoundReturnByUrlAsync(roundUrl);
        }
        public async Task<TournamentRoundReturn?> GetTournamentRoundAsync(string tournamentId, int roundNumber)
        {
            return await TournamentRoundsEndpoint.GetTournamentRoundReturnAsync(tournamentId, roundNumber);
        }
        public async Task<TournamentRoundGroupDetails?> GetTournamentRoundGroupDetailsAsync(string url)
        {
            return await TournamentRoundGroupsEndpoint.GetTournamentRoundGroupDetailsByUrlAsync(url);
        }
        public async Task<TournamentRoundGroupDetails?> GetTournamentRoundGroupDetailsAsync(string tournamentId, int roundNumber, int groupNumber)
        {
            return await TournamentRoundGroupsEndpoint.GetTournamentRoundGroupDetailsAsync(tournamentId, roundNumber, groupNumber);
        }
    }
}
