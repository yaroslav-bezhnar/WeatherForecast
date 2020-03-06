using Newtonsoft.Json;

namespace OpenCageGeocoderApi.Library.Models
{
    /// <summary>
    ///     Represents geographical coordinates of the location.
    /// </summary>
    public struct GeoCoordinates
    {
        #region Properties

        /// <summary>
        ///     Gets\Sets the latitude of the geographical coordinates.
        /// </summary>
        [JsonProperty( "lat" )]
        public double Latitude
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the longitude of the geographical coordinates.
        /// </summary>
        [JsonProperty( "lng" )]
        public double Longitude
        {
            get;
            set;
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Overriden ToString method.
        /// </summary>
        /// <returns>A string representation of the <see cref="GeoCoordinates" /> struct.</returns>
        public override string ToString() => $"Latitude: {Latitude}, Longitude: {Longitude}";

        #endregion
    }
}
