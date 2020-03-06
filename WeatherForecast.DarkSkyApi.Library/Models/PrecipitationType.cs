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
        Rain,

        /// <summary>
        ///     Snow.
        /// </summary>
        Snow,

        /// <summary>
        ///     Sleet.
        /// </summary>
        Sleet
    }
}
