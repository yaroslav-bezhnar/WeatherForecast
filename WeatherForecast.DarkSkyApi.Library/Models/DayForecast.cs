﻿using System;
using Newtonsoft.Json;
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
        [JsonProperty( "sunriseTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset SunriseTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time of when the sun will set during a given day.
        /// </summary>
        [JsonProperty( "sunsetTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset SunsetTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets a value representing the fractional part of the lunation number during the given day:
        ///     a value of '0' corresponds to a new moon, '0.25' to a first quarter moon,
        ///     '0.5' to a full moon, and '0.75' to a last quarter moon.
        /// </summary>
        [JsonProperty( "moonPhase" )]
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
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset PrecipitationIntensityMaxTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the daytime high temperature.
        /// </summary>
        [JsonProperty( "temperatureHigh" )]
        public float TemperatureHigh
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the daytime high temperature occurs.
        /// </summary>
        [JsonProperty( "temperatureHighTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset TemperatureHighTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the overnight low temperature.
        /// </summary>
        [JsonProperty( "temperatureLow" )]
        public float TemperatureLow
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the overnight low temperature occurs.
        /// </summary>
        [JsonProperty( "temperatureLowTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset TemperatureLowTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the maximum temperature during a given date.
        /// </summary>
        [JsonProperty( "temperatureMax" )]
        public float TemperatureMax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the maximum temperature during a given date occurs.
        /// </summary>
        [JsonProperty( "temperatureMaxTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset TemperatureMaxTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the minimum temperature during a given date.
        /// </summary>
        [JsonProperty( "temperatureMin" )]
        public float TemperatureMin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the minimum temperature during a given date occurs.
        /// </summary>
        [JsonProperty( "temperatureMinTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset TemperatureMinTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the daytime high apparent temperature.
        /// </summary>
        [JsonProperty( "apparentTemperatureHigh" )]
        public float ApparentTemperatureHigh
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the daytime high apparent temperature occurs.
        /// </summary>
        [JsonProperty( "apparentTemperatureHighTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset ApparentTemperatureHighTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the overnight low apparent temperature.
        /// </summary>
        [JsonProperty( "apparentTemperatureLow" )]
        public float ApparentTemperatureLow
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the overnight low apparent temperature occurs.
        /// </summary>
        [JsonProperty( "apparentTemperatureLowTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset ApparentTemperatureLowTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the maximum apparent temperature during a given date.
        /// </summary>
        [JsonProperty( "apparentTemperatureMax" )]
        public float ApparentTemperatureMax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing when the maximum apparent temperature during a given date occurs.
        /// </summary>
        [JsonProperty( "apparentTemperatureMaxTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset ApparentTemperatureMaxTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the minimum apparent temperature during a given date.
        /// </summary>
        [JsonProperty( "apparentTemperatureMin" )]
        public float ApparentTemperatureMin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time representing  when the minimum apparent temperature during a given date occurs.
        /// </summary>
        [JsonProperty( "apparentTemperatureMinTime" )]
        [JsonConverter( typeof( UtcDateTimeOffsetJsonConverter ) )]
        public DateTimeOffset ApparentTemperatureMinTime
        {
            get;
            set;
        }

        #endregion
    }
}