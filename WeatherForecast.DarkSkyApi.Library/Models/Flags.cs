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

        // TODO: below is needed?

        /// <summary>
        ///     Gets/Sets the IDs for each radar station used to provide info for this forecast.
        /// </summary>
        [JsonProperty( "darksky-stations" )]
        public IList<string> DarkSkyStations
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the IDs for each DataPoint station used to provide info for this forecast.
        /// </summary>
        [JsonProperty( "datapoint-stations" )]
        public IList<string> DataPointStations
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the IDs for each ISD station used to provide info for this forecast.
        /// </summary>
        [JsonProperty( "isd-stations" )]
        public IList<string> IsdStations
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the IDs for each LAMP station used to provide info for this forecast.
        /// </summary>
        [JsonProperty( "lamp-stations" )]
        public IList<string> LampStations
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the IDs for each METAR station used to provide info for this forecast.
        /// </summary>
        [JsonProperty( "metar-stations" )]
        public IList<string> MetarStations
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the IDs for each MADIS station used to provide info for this forecast.
        /// </summary>
        [JsonProperty( "madis-stations" )]
        public IList<string> MadisStations
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the met.no license. If this is present, data from api.met.no was used to provide info for this forecast.
        /// </summary>
        [JsonProperty( "metno-license" )]
        public string MetnoLicense
        {
            get;
            set;
        }

        #endregion
    }
}
