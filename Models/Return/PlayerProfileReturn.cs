using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Chesscom.Api.Net.Models.Return
{
    public class PlayerProfileReturn
    {
        [JsonProperty("@id")]
        public string? Id;
        [JsonProperty("url")]
        public string? Url;
        [JsonProperty("username")]
        public string? Username;
        [JsonProperty("player_id")]
        public long? PlayerId;
        [JsonProperty("title")]
        public string? Title;
        [JsonProperty("status")]
        public string? Status;
        [JsonProperty("name")]
        public string? Name;
        [JsonProperty("avatar")]
        public string? Avatar;
        [JsonProperty("location")]
        public string? Location;
        [JsonProperty("country")]
        public string? Country;
        [JsonProperty("joined"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Joined;
        [JsonProperty("last_online"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? LastOnline;
        [JsonProperty("followers")]
        public int? Followers;
        [JsonProperty("is_streamer")]
        public bool? IsStreamer;
        [JsonProperty("twitch_url")]
        public string? TwitchUrl;
        [JsonProperty("fide")]
        public int? Fide;
    }
}
