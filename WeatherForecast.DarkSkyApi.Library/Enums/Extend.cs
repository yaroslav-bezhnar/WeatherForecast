using System.ComponentModel;
using WeatherForecast.DarkSkyApi.Library.Attributes;

namespace WeatherForecast.DarkSkyApi.Library
{
    /// <summary>
    ///     Data blocks that can have their ranges extended.
    /// </summary>
    [DefaultValue( Hourly )]
    public enum Extend
    {
        /// <summary>
        ///     Extends the hourly forecast block to the next seven days from just the next two.
        /// </summary>
        [EnumStringValue( "hourly" )]
        Hourly
    }
}
