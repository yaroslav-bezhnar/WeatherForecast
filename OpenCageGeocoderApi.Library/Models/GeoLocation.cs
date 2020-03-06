using Newtonsoft.Json;

namespace OpenCageGeocoderApi.Library.Models
{
    /// <summary>
    ///     Represents a class that contains information about geographical location.
    /// </summary>
    public class GeoLocation
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets the bounds of the geographical location.
        /// </summary>
        public Bounds Bounds
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the geographical location components.
        /// </summary>
        public GeoLocationComponents Components
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the coordinates of the location.
        /// </summary>
        [JsonProperty( "geometry" )]
        public GeoCoordinates Coordinates
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets a well formatted version of the place name.
        ///     Display the name of the location that would make sense to humans.
        /// </summary>
        public string Formatted
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the confidence score of the geographical location.
        ///     Value between 0 and 10 , where 0 reflects inability to determine a confidence (due to lack of a bounding box), 1 indicates low precision, and 10 indicates high precision.
        /// </summary>
        public int Confidence
        {
            get;
            set;
        }

        #endregion
    }
}
