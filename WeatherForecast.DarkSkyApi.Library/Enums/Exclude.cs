using WeatherForecast.DarkSkyApi.Library.Attributes;

namespace WeatherForecast.DarkSkyApi.Library
{
    /// <summary>
    ///     Data blocks that can be excluded from a request.
    /// </summary>
    public enum Exclude
    {
        /// <summary>
        ///     The current data block, containing current weather conditions.
        /// </summary>
        [EnumStringValue( "currently" )]
        Currently,

        /// <summary>
        ///     The minutely data block, containing minute-by-minute data for the next hour.
        /// </summary>
        [EnumStringValue( "minutely" )]
        Minutely,

        /// <summary>
        ///     The hourly data block, containing hour-by-hour data for the next two days (or the next week, if extended).
        /// </summary>
        [EnumStringValue( "hourly" )]
        Hourly,

        /// <summary>
        ///     The daily data block, containing day-by-day data for the next week.
        /// </summary>
        [EnumStringValue( "daily" )]
        Daily,

        /// <summary>
        ///     A list of any severe weather alerts issued for the requested location.
        /// </summary>
        [EnumStringValue( "alerts" )]
        Alerts,

        /// <summary>
        ///     Associated metadata related to the request.
        /// </summary>
        [EnumStringValue( "flags" )]
        Flags
    }
}
