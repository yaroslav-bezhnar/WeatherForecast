using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenCageGeocoderApi.Library.Exceptions;
using OpenCageGeocoderApi.Library.Models;

namespace OpenCageGeocoderApi.Library
{
    /// <summary>
    ///     Represents a class that provides service to convert coordinates to and from places.
    ///     Wrapper for interacting with the OpenCage Geocoder API.
    /// </summary>
    public class OpenCageGeoService
    {
        #region Static Fields

        /// <summary>
        ///     The OpenCage Geocoder API endpoint to retrieve geocoding.
        /// </summary>
        private const string OPEN_CAGE_GEO_FORMAT_URL = "https://api.opencagedata.com/geocode/v1/json?key={0}&q={1}&no_annotations=1&no_dedupe=1";

        #endregion

        #region Fields

        /// <summary>
        ///     The OpenCage Geocoder API secret key.
        /// </summary>
        private readonly string _apiKey;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenCageGeoService" /> class.
        ///     A wrapper for the OpenCage Geocoder API.
        /// </summary>
        /// <param name="apiKey">A OpenCage Geocoder API secret key.</param>
        /// <exception cref="OpenCageGeoException">Throws if OpenCage Geocoder API secret key not specified.</exception>
        public OpenCageGeoService( string apiKey )
        {
            AssertApiKey( apiKey );

            _apiKey = apiKey;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the total number of transactions that your account is limited to over a 24 hour period.
        /// </summary>
        public int? ApiLimit
        {
            get;
            private set;
        }

        /// <summary>
        ///     Gets the number of transactions remaining in the current 24 hour period.
        /// </summary>
        public int? ApiRemaining
        {
            get;
            private set;
        }

        /// <summary>
        ///     Gets the date and time, in UNIX format, at which your transaction count will reset.
        /// </summary>
        public int? ApiReset
        {
            get;
            private set;
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Retrieves the OpenCage Geocoder coordinates asynchronously.
        /// </summary>
        /// <param name="location">The location to retrieve data for.</param>
        /// <returns>The OpenCage Geocoder coordinates response.</returns>
        public async Task<OpenCageGeoResponse> GetGeoCoordinatesAsync( string location )
        {
            return await GetGeocoderResponseAsync( location );
        }

        /// <summary>
        ///     Retrieves the OpenCage Geocoder coordinates asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <returns>The OpenCage Geocoder coordinates response.</returns>
        public async Task<OpenCageGeoResponse> GetGeoCoordinatesAsync( double latitude, double longitude )
        {
            return await GetGeocoderResponseAsync( $"{latitude}+{longitude}" );
        }

        #endregion

        #region Private Methods

        /// <summary>
        ///     Retrieves the OpenCage Geocoder data asynchronously.
        /// </summary>
        /// <param name="query">The query to retrieve data for.</param>
        /// <returns>The OpenCage Geocoder response.</returns>
        private async Task<OpenCageGeoResponse> GetGeocoderResponseAsync( string query )
        {
            var url = string.Format( OPEN_CAGE_GEO_FORMAT_URL, _apiKey, WebUtility.UrlEncode( query ) );
            var request = (HttpWebRequest) WebRequest.Create( url );
            request.Method = "GET";
            request.ContentType = "application/json";

            try
            {
                using ( var response = (HttpWebResponse) request.GetResponse() )
                {
                    AssertResponseStatusCode( response );

                    ApiLimit = int.Parse( response.Headers["X-RateLimit-Limit"] );
                    ApiRemaining = int.Parse( response.Headers["X-RateLimit-Remaining"] );
                    ApiReset = int.Parse( response.Headers["X-RateLimit-Reset"] );

                    using (var stream = response.GetResponseStream())
                    {
                        AssertStream( stream );

                        using ( var reader = new StreamReader( stream ) )
                        {
                            var jsonResponse = await reader.ReadToEndAsync().ConfigureAwait( false );

                            return JsonConvert.DeserializeObject<OpenCageGeoResponse>( jsonResponse );
                        }
                    }
                }
            }
            catch ( WebException ex )
            {
                throw new OpenCageGeoException( "Request to OpenCage Geocoder API failed.", ex );
            }
        }

        /// <summary>
        ///     Checks if OpenCage Geocoder API secret key is provided.
        /// </summary>
        /// <param name="apiKey">API key.</param>
        /// <exception cref="OpenCageGeoException">Throws if API key is not provided (null, empty or white space string).</exception>
        private static void AssertApiKey( string apiKey )
        {
            if ( string.IsNullOrWhiteSpace( apiKey ) ) throw new OpenCageGeoException( "OpenCage Geocoder API secret key is not specified." );
        }

        /// <summary>
        ///     Checks the status of the HTTP Web response.
        /// </summary>
        /// <param name="response">HTTP Web response resource.</param>
        /// <exception cref="OpenCageGeoException">Throws if <see cref="HttpWebResponse.StatusCode" /> is not <see cref="HttpStatusCode.OK" /> (status not 200).</exception>
        private static void AssertResponseStatusCode( HttpWebResponse response )
        {
            if ( response.StatusCode != HttpStatusCode.OK ) throw new OpenCageGeoException( response.StatusDescription );
        }

        /// <summary>
        ///     Checks if IO Stream in not null.
        /// </summary>
        /// <param name="stream">The stream that used to read the body of the response from the server.</param>
        /// <exception cref="OpenCageGeoException">Throws if IO Stream is null.</exception>
        private static void AssertStream( Stream stream )
        {
            if ( stream == null ) throw new OpenCageGeoException( "Failed to receive Response." );
        }

        #endregion
    }
}
