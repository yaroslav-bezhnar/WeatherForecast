﻿namespace WeatherForecast.DarkSkyApi.Library.Models
{
    /// <summary>
    ///     Represents a class that contains a current weather conditions at the requested location.
    /// </summary>
    public class CurrentForecast : GeneralForecast
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets the approximate distance to the nearest storm.
        /// </summary>
        public float NearestStormDistance
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the approximate direction of the nearest storm, in degrees.
        /// </summary>
        public float NearestStormBearing
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the amount of snowfall accumulation expected to occur.
        /// </summary>
        public float PrecipitationAccumulation
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the air temperature, in degrees.
        /// </summary>
        public float Temperature
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the apparent ("feels like") temperature, in degrees.
        /// </summary>
        public float ApparentTemperature
        {
            get;
            set;
        }

        #endregion
    }
}
