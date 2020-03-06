using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WeatherForecast.DarkSkyApi.Library.Models
{
    /// <summary>
    ///     Represents the severity of a weather alert.
    /// </summary>
    [JsonConverter( typeof( StringEnumConverter ) )]
    public enum Severity
    {
        /// <summary>
        ///     The severity of this alert is not recognized.
        /// </summary>
        [EnumMember( Value = null )]
        Unknown,

        /// <summary>
        ///     Indicates that individuals should be aware of potentially severe weather.
        /// </summary>
        Advisory,

        /// <summary>
        ///     Indicates that individuals should prepare for potentially severe weather.
        /// </summary>
        Watch,

        /// <summary>
        ///     Indicates that individuals should take immediate action to protect themselves and others from potentially severe weather.
        /// </summary>
        Warning
    }
}
