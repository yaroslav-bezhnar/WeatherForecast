using System;

namespace OpenCageGeocoderApi.Library.Exceptions
{
    /// <summary>
    ///     Represents errors that occur when use Open Cage Geocoder service.
    /// </summary>
    public class OpenCageGeoException : Exception
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenCageGeoException" /> class.
        /// </summary>
        public OpenCageGeoException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenCageGeoException" /> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public OpenCageGeoException( string message ) : base( message )
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenCageGeoException" /> class with a specified error message and a reference to the inner exception.
        /// </summary>
        /// <param name="message">The message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public OpenCageGeoException( string message, Exception innerException ) : base( message, innerException )
        {
        }

        #endregion
    }
}
