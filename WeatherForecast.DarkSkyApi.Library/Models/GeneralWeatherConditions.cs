using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherForecast.DarkSkyApi.Library.Models
{
    /// <summary>
    ///     Represents a class that contains the various weather phenomena occurring over a period of time.
    /// </summary>
    /// <typeparam name="TCondition">Weather forecast condition.</typeparam>
    public class GeneralWeatherConditions<TCondition> where TCondition : GeneralForecast
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets a human-readable summary of the forecast.
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
        ///     Gets/Sets the list of <see cref="TCondition" />, ordered by time, which together describe the weather
        ///     conditions at the requested location over time.
        /// </summary>
        [JsonProperty( Required = Required.Always )]
        public IList<TCondition> Data
        {
            get;
            set;
        }

        #endregion
    }
}
