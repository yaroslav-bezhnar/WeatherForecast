﻿using Newtonsoft.Json;
using NodaTime;
using WeatherForecast.DarkSkyApi.Library.Converters;

namespace WeatherForecast.DarkSkyApi.Library.Models
{
    /// <summary>
    ///     Represents a base class for weather conditions that contains general weather forecast information.
    /// </summary>
    public abstract class GeneralForecast
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets the UNIX time at which these conditions begins.
        ///     The point of time provided all according to the local time zone.
        /// </summary>
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant Time
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets a human-readable text summary of this data point.
        /// </summary>
        public string Summary
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets a machine-readable text summary that can be used to select an icon to display.
        /// </summary>
        public string Icon
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the intensity of precipitation occurring at the given time.
        /// </summary>
        [JsonProperty( "precipIntensity" )]
        public float PrecipitationIntensity
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the standard deviation of the distribution of 'PrecipitationIntensity' property.
        /// </summary>
        [JsonProperty( "precipIntensityError" )]
        public float PrecipitationIntensityError
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the probability of precipitation occurring, between '0' and '1', inclusive.
        /// </summary>
        [JsonProperty( "precipProbability" )]
        public float PrecipitationProbability
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the type of precipitation occurring at the given time ('Rain', 'Snow', or 'Sleet').
        /// </summary>
        [JsonProperty( "precipType" )]
        public PrecipitationType Precipitation
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the dew point, in degrees.
        /// </summary>
        public float DewPoint
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the relative humidity, between '0' and '1', inclusive.
        /// </summary>
        public float Humidity
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the sea-level air pressure.
        /// </summary>
        public float Pressure
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the wind speed per hour.
        /// </summary>
        public float WindSpeed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the wind gust speed per hour.
        /// </summary>
        public float WindGust
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the direction (in degrees) that the wind is coming from.
        /// </summary>
        public float WindBearing
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the percentage of sky occluded by clouds, between 0 and 1, inclusive.
        /// </summary>
        public float CloudCover
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UV index.
        /// </summary>
        public float UVIndex
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the average visibility (capped at 10 miles).
        /// </summary>
        public float Visibility
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the columnar density of total atmospheric ozone at the given time, in Dobson units.
        /// </summary>
        public float Ozone
        {
            get;
            set;
        }

        #endregion
    }
}
