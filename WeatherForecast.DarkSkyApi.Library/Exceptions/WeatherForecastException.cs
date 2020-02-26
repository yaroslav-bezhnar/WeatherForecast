using System;

namespace WeatherForecast.DarkSkyApi.Library.Exceptions
{
    /// <summary>
    ///     Represents errors that occur when use weather forecast service.
    /// </summary>
    public class WeatherForecastException : Exception
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="WeatherForecastException" /> class.
        /// </summary>
        public WeatherForecastException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WeatherForecastException" /> class
        ///     with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public WeatherForecastException( string message ) : base( message )
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WeatherForecastException" /> class
        ///     with a specified error message and a reference to the inner exception.
        /// </summary>
        /// <param name="message">The message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public WeatherForecastException( string message, Exception innerException ) : base( message, innerException )
        {
        }

        #endregion
    }
}
