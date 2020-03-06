using Newtonsoft.Json;
using NodaTime;
using WeatherForecast.DarkSkyApi.Library.Converters;

namespace WeatherForecast.DarkSkyApi.Library.Models
{
    /// <summary>
    ///     Represents a class that contains a weather conditions for a particular day.
    /// </summary>
    public class DayForecast : CurrentForecast
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets the UNIX time of when the sun will rise during a given day.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant SunriseTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time of when the sun will set during a given day.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant SunsetTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets a value representing the fractional part of the lunation number during the given day:
        ///     a value of '0' corresponds to a new moon, '0.25' to a first quarter moon,
        ///     '0.5' to a full moon, and '0.75' to a last quarter moon.
        /// </summary>
        public float MoonPhase
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the maximum value of 'PrecipitationIntensity' during a given day.
        /// </summary>
        [JsonProperty( "precipIntensityMax" )]
        public float PrecipitationIntensityMax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time of when 'PrecipitationIntensityMax' occurs during a given day.
        /// </summary>
        [JsonProperty( "precipIntensityMaxTime" )]
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant PrecipitationIntensityMaxTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the daytime high temperature.
        /// </summary>
        public float TemperatureHigh
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the daytime high temperature occurs.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant TemperatureHighTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the overnight low temperature.
        /// </summary>
        public float TemperatureLow
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the overnight low temperature occurs.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant TemperatureLowTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the maximum temperature during a given date.
        /// </summary>
        public float TemperatureMax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the maximum temperature during a given date occurs.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant TemperatureMaxTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the minimum temperature during a given date.
        /// </summary>
        public float TemperatureMin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the minimum temperature during a given date occurs.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant TemperatureMinTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the daytime high apparent temperature.
        /// </summary>
        public float ApparentTemperatureHigh
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the daytime high apparent temperature occurs.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant ApparentTemperatureHighTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the overnight low apparent temperature.
        /// </summary>
        public float ApparentTemperatureLow
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the overnight low apparent temperature occurs.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant ApparentTemperatureLowTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the maximum apparent temperature during a given date.
        /// </summary>
        public float ApparentTemperatureMax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the maximum apparent temperature during a given date occurs.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant ApparentTemperatureMaxTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the minimum apparent temperature during a given date.
        /// </summary>
        public float ApparentTemperatureMin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing  when the minimum apparent temperature during a given date occurs.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant ApparentTemperatureMinTime
        {
            get;
            set;
        }

        #endregion
    }
}
