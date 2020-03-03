using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherForecast.DarkSkyApi.Library.Models
{
    /// <summary>
    ///     Represents a class that contains various metadata information related to the request.
    /// </summary>
    public class Flags
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets indicates that the Dark Sky data source supports the given location,
        ///     but a temporary error (such as a radar station being down for maintenance) has made the data unavailable.
        /// </summary>
        [JsonProperty( "darksky-unavailable" )]
        public string DarkSkyUnavailable
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the distance to the nearest weather station that contributed data to this response.
        /// </summary>
        [JsonProperty( "nearest-station", Required = Required.Always )]
        public float NearestStation
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the IDs for each data source utilized in servicing this request.
        /// </summary>
        [JsonProperty( "sources", Required = Required.Always )]
        public IList<string> Sources
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the units which were used for the data in this request.
        /// </summary>
        [JsonProperty( "units", Required = Required.Always )]
        public string Units
        {
            get;
            set;
        }

        #endregion
    }
}
