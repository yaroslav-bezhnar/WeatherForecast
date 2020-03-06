namespace OpenCageGeocoderApi.Library.Models
{
    /// <summary>
    ///     Represents a status of the OpenCage Geocoder Api response.
    /// </summary>
    public class Status
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets code of the OpenCage Geocoder Api response status.
        /// </summary>
        public int Code
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets message of the OpenCage Geocoder Api response status.
        /// </summary>
        public string Message
        {
            get;
            set;
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Overriden ToString method.
        /// </summary>
        /// <returns>A string representation of the <see cref="Status" /> object.</returns>
        public override string ToString() => $"{Code} \"{Message}\"";

        #endregion
    }
}
