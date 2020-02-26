using System.ComponentModel;
using WeatherForecast.DarkSkyApi.Library.Attributes;

namespace WeatherForecast.DarkSkyApi.Library
{
    /// <summary>
    ///     Units of measurement supported by the Weather Forecast service.
    /// </summary>
    [DefaultValue( US )]
    public enum Unit
    {
        /// <summary>
        ///     Automatically select units based on geographic location.
        /// </summary>
        [EnumStringValue( "auto" )]
        Auto,

        /// <summary>
        ///     Canadian units. The same as SI, except that 'WindSpeed' and 'WindGust' are in kilometers per hour.
        /// </summary>
        [EnumStringValue( "ca" )]
        CA,

        /// <summary>
        ///     United Kingdom units. The same as SI, except that 'NearestStormDistance' and 'Visibility' are in miles,
        ///     and 'WindSpeed' and 'WindGust' in miles per hour.
        /// </summary>
        [EnumStringValue( "uk2" )]
        UK,

        /// <summary>
        ///     United States units. Imperial units (the default).
        /// </summary>
        [EnumStringValue( "us" )]
        US,

        /// <summary>
        ///     SI units.
        /// </summary>
        [EnumStringValue( "si" )]
        SI
    }
}
