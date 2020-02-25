using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherForecast.DarkSkyApi.Library.Models
{
    /// <summary>
    ///     Represents a class that contains a weather forecast for a particular location.
    /// </summary>
    public class WeatherForecastResponse
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets the requested latitude.
        /// </summary>
        [JsonProperty( "latitude", Required = Required.Always )]
        public float Latitude
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the requested longitude.
        /// </summary>
        [JsonProperty( "longitude", Required = Required.Always )]
        public float Longitude
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the IANA timezone name for the requested location.
        /// </summary>
        [JsonProperty( "timezone", Required = Required.Always )]
        public string TimeZone
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the current timezone offset in hours.
        ///     Deprecated: use 'TimeZone', instead.
        /// </summary>
        [JsonProperty( "offset" )]
        [Obsolete( "Use 'TimeZone', instead." )]
        public double Offset
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the the current weather conditions at the requested location.
        /// </summary>
        [JsonProperty( "currently" )]
        public CurrentForecast Currently
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the weather conditions minute-by-minute for the next hour.
        /// </summary>
        [JsonProperty( "minutely" )]
        public GeneralWeatherConditions<MinuteForecast> Minutely
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the weather conditions hour-by-hour for the next two days.
        /// </summary>
        [JsonProperty( "hourly" )]
        public GeneralWeatherConditions<HourForecast> Hourly
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the weather conditions day-by-day for the next week.
        /// </summary>
        [JsonProperty( "daily" )]
        public GeneralWeatherConditions<DayForecast> Daily
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets any severe weather alerts pertinent to the requested location.
        /// </summary>
        [JsonProperty( "alerts" )]
        public IList<Alert> Alerts
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the metadata (flags) associated with this weather forecast.
        /// </summary>
        [JsonProperty( "flags" )]
        public Flags Flags
        {
            get;
            set;
        }

        #endregion
    }
}
