using System.Text.Json.Serialization;

namespace JuiceboxServer.Models.Spotify
{
    public class SearchObject<T>
    {
        /// <summary>
        /// A link to the Web API endpoint returning the full result of the request
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; } = null!;

        /// <summary>
        /// The maximum number of items in the response (as set in the query or by default).
        /// </summary>
        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// URL to the next page of items. ( null if none)
        /// </summary>
        [JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// The offset of the items returned (as set in the query or by default)
        /// </summary>
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// URL to the previous page of items. ( null if none)
        /// </summary>
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// The total number of items available to return.
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// Collection of items.
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<T> Items { get; set; } = null!;
    }
}