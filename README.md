# Chesscom.Api.Net
.NET Wrapper for the Chess.com Published API

## Usage
Create a new ChesscomClient object, supplying the identifying user agent for a way to contact you (email address, Chess.com username, etc.)
There are various endpoints you can call to retrieve user game information, or user profile information, as shown in this example:

```csharp
ChesscomClient chesscomClient = new ChesscomClient("neondactyl@chess.com");

var playerProfile = await chesscomClient.GetPlayerProfileByUsernameAsync("neondactyl");

var grandmasters = await chesscomClient.GetPlayersByTitleAsync(ChessTitle.GM);

var internationalMasters = await chesscomClient.GetPlayersByTitleAsync(ChessTitle.IM);

var playerStats = await chesscomClient.GetPlayerStatsByUsernameAsync("neondactyl");

var isPlayerOnline = await chesscomClient.GetIsPlayerOnlineByUsernameAsync("neondactyl");

var playerToMoveDaily = await chesscomClient.GetCurrentToMoveDailyByUsername("neondactyl");

var playerArchives = await chesscomClient.GetPlayerArchivesByUsernameAsync("neondactyl");
PlayerMonthArchiveReturn? monthGames = null;
if (playerArchives is not null)
    monthGames = await chesscomClient.GetPlayerMonthArchiveByUrlAsync(playerArchives.Archives.First());

var apr2022Games = await chesscomClient.GetPlayerMonthArchiveByUsernameYearMonthAsync("neondactyl", 2022, 4);
```

More documentation and improved information to follow at a later date.
