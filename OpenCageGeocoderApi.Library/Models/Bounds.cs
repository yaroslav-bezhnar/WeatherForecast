namespace OpenCageGeocoderApi.Library.Models
{
    /// <summary>
    ///     Represents bounds of the geographical location.
    /// </summary>
    public struct Bounds
    {
        #region Properties

        /// <summary>
        ///     Gets\Sets the NorthEast bound.
        /// </summary>
        public GeoCoordinates NorthEast
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets\Sets the SouthWest bound.
        /// </summary>
        public GeoCoordinates SouthWest
        {
            get;
            set;
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Overriden ToString method.
        /// </summary>
        /// <returns>A string representation of the <see cref="Bounds" /> struct.</returns>
        public override string ToString() => $"NorthEast: {NorthEast}, SouthWest: {SouthWest}";

        #endregion
    }
}
