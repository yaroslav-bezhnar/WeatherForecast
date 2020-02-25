using System.Runtime.Serialization;

namespace WeatherForecast.DarkSkyApi.Library.Models
{
    /// <summary>
    ///     The type of precipitation occurring at the given time.
    /// </summary>
    public enum PrecipitationType
    {
        /// <summary>
        ///     An unknown precipitation.
        /// </summary>
        [EnumMember( Value = null )]
        None,

        /// <summary>
        ///     Rain.
        /// </summary>
        [EnumMember( Value = "rain" )]
        Rain,

        /// <summary>
        ///     Snow.
        /// </summary>
        [EnumMember( Value = "snow" )]
        Snow,

        /// <summary>
        ///     Sleet.
        /// </summary>
        [EnumMember( Value = "sleet" )]
        Sleet
    }
}
