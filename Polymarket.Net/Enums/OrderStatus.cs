using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace Polymarket.Net.Enums
{
    /// <summary>
    /// Order status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<OrderStatus>))]
    public enum OrderStatus
    {
        /// <summary>
        /// ["<c>LIVE</c>"] Live
        /// </summary>
        [Map("LIVE", "live")]
        Live,
        /// <summary>
        /// ["<c>CANCELED</c>"] Canceled
        /// </summary>
        [Map("CANCELED", "canceled")]
        Canceled,
        /// <summary>
        /// ["<c>MATCHED</c>"] Matched
        /// </summary>
        [Map("MATCHED", "matched")]
        Matched,
        /// <summary>
        /// Unmatched
        /// </summary>
        [Map("UNMATCHED", "unmatched")]
        Unmatched,
        /// <summary>
        /// Delayed
        /// </summary>
        [Map("DELAYED", "delayed")]
        Delayed
    }
}
