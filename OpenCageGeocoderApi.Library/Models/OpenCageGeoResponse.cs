using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenCageGeocoderApi.Library.Models
{
    /// <summary>
    ///     Represents a <see cref="OpenCageGeoResponse" /> class.
    /// </summary>
    public class OpenCageGeoResponse
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets the status of the OpenCage Geocoder Api response.
        /// </summary>
        public Status Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the list of the geographical location results.
        /// </summary>
        [JsonProperty( "results" )]
        public IList<GeoLocation> Locations
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the total results of the OpenCage Geocoder Api response.
        /// </summary>
        [JsonProperty( "total_results" )]
        public int TotalResults
        {
            get;
            set;
        }

        #endregion
    }
}
