using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherForecast.DarkSkyApi.Library.Exceptions;
using WeatherForecast.DarkSkyApi.Library.Models;
using static WeatherForecast.DarkSkyApi.Library.Helpers.EnumHelper;

namespace WeatherForecast.DarkSkyApi.Library
{
    /// <summary>
    ///     Represents a class that provides weather forecast service.
    ///     Wrapper for interacting with the DarkSky API.
    /// </summary>
    public class WeatherForecastService
    {
        #region Static Fields

        /// <summary>
        ///     The DarkSky API endpoint to retrieve current weather conditions.
        /// </summary>
        private const string CURRENT_WEATHER_FORECAST_URL = "https://api.darksky.net/forecast/{0}/{1},{2}?units={3}&lang={4}&extend={5}&exclude={6}";

        /// <summary>
        ///     The DarkSky API endpoint to retrieve weather conditions at the particular date and time.
        /// </summary>
        private const string TIME_SPECIFIED_WEATHER_FORECAST_URL = "https://api.darksky.net/forecast/{0}/{1},{2},{7}?units={3}&lang={4}&extend={5}&exclude={6}";

        #endregion

        #region Fields

        /// <summary>
        ///     The DarkSky API secret key.
        /// </summary>
        private readonly string _apiKey;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="WeatherForecastService" /> class.
        ///     A wrapper for the Dark Sky API.
        /// </summary>
        /// <param name="apiKey">A DarkSky API secret key.</param>
        /// <exception cref="WeatherForecastException">Throws if DarkSky API secret key not specified.</exception>
        public WeatherForecastService( string apiKey )
        {
            AssertApiKey( apiKey );

            _apiKey = apiKey;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the number of API requests made by the given API key for today.
        /// </summary>
        public int? ApiCallsMade
        {
            get;
            private set;
        }

        /// <summary>
        ///     Gets the server-side response time of the request.
        /// </summary>
        public string ApiResponseTime
        {
            get;
            private set;
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude )
        {
            return await GetWeatherForecastAsync( latitude, longitude, null, GetDefaultValue<Unit>(), GetDefaultValue<Language>(), null, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="dateTime">The date to retrieve data for.
        /// Returns the observed (in the past) or forecasted (in the future) hour-by-hour weather and daily weather conditions for a particular date.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, DateTimeOffset? dateTime )
        {
            return await GetWeatherForecastAsync( latitude, longitude, dateTime, GetDefaultValue<Unit>(), GetDefaultValue<Language>(), null, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="unit">The units of weather conditions.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, Unit unit )
        {
            return await GetWeatherForecastAsync( latitude, longitude, null, unit, GetDefaultValue<Language>(), null, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="dateTime">The date to retrieve data for.
        /// Returns the observed (in the past) or forecasted (in the future) hour-by-hour weather and daily weather conditions for a particular date.</param>
        /// <param name="unit">The units of weather conditions.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, DateTimeOffset? dateTime, Unit unit )
        {
            return await GetWeatherForecastAsync( latitude, longitude, dateTime, unit, GetDefaultValue<Language>(), null, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="language">The language to use for 'Summary' properties.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, Language language )
        {
            return await GetWeatherForecastAsync( latitude, longitude, null, GetDefaultValue<Unit>(), language, null, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="dateTime">The date to retrieve data for.
        /// Returns the observed (in the past) or forecasted (in the future) hour-by-hour weather and daily weather conditions for a particular date.</param>
        /// <param name="language">The language to use for 'Summary' properties.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, DateTimeOffset? dateTime, Language language )
        {
            return await GetWeatherForecastAsync( latitude, longitude, dateTime, GetDefaultValue<Unit>(), language, null, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="unit">The units of weather conditions.</param>
        /// <param name="language">The language to use for 'Summary' properties.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, Unit unit, Language language )
        {
            return await GetWeatherForecastAsync( latitude, longitude, null, unit, language, null, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="dateTime">The date to retrieve data for.
        /// Returns the observed (in the past) or forecasted (in the future) hour-by-hour weather and daily weather conditions for a particular date.</param>
        /// <param name="unit">The units of weather conditions.</param>
        /// <param name="language">The language to use for 'Summary' properties.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, DateTimeOffset? dateTime, Unit unit, Language language )
        {
            return await GetWeatherForecastAsync( latitude, longitude, dateTime, unit, language, null, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="unit">The units of weather conditions.</param>
        /// <param name="language">The language to use for 'Summary' properties.</param>
        /// <param name="extends">The type of weather forecast to retrieve extended results for.
        /// When present, return hour-by-hour data for the next 168 hours, instead of the next 48.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, Unit unit, Language language, IList<Extend> extends )
        {
            return await GetWeatherForecastAsync( latitude, longitude, null, unit, language, extends, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="dateTime">The date to retrieve data for.
        /// Returns the observed (in the past) or forecasted (in the future) hour-by-hour weather and daily weather conditions for a particular date.</param>
        /// <param name="unit">The units of weather conditions.</param>
        /// <param name="language">The language to use for 'Summary' properties.</param>
        /// <param name="extends">The type of weather forecast to retrieve extended results for.
        /// When present, return hour-by-hour data for the next 168 hours, instead of the next 48.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, DateTimeOffset? dateTime, Unit unit, Language language, IList<Extend> extends )
        {
            return await GetWeatherForecastAsync( latitude, longitude, dateTime, unit, language, extends, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="unit">The units of weather conditions.</param>
        /// <param name="language">The language to use for 'Summary' properties.</param>
        /// <param name="excludes">Blocks that should be excluded from the API response.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, Unit unit, Language language, IList<Exclude> excludes )
        {
            return await GetWeatherForecastAsync( latitude, longitude, null, unit, language, null, excludes );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="dateTime">The date to retrieve data for.
        /// Returns the observed (in the past) or forecasted (in the future) hour-by-hour weather and daily weather conditions for a particular date.</param>
        /// <param name="unit">The units of weather conditions.</param>
        /// <param name="language">The language to use for 'Summary' properties.</param>
        /// <param name="excludes">Blocks that should be excluded from the API response.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, DateTimeOffset? dateTime, Unit unit, Language language, IList<Exclude> excludes )
        {
            return await GetWeatherForecastAsync( latitude, longitude, dateTime, unit, language, null, excludes );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="extends"> The type of weather forecast to retrieve extended results for.
        /// When present, return hour-by-hour data for the next 168 hours, instead of the next 48.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, IList<Extend> extends )
        {
            return await GetWeatherForecastAsync( latitude, longitude, null, GetDefaultValue<Unit>(), GetDefaultValue<Language>(), extends, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="dateTime">The date to retrieve data for.
        /// Returns the observed (in the past) or forecasted (in the future) hour-by-hour weather and daily weather conditions for a particular date.</param>
        /// <param name="extends"> The type of weather forecast to retrieve extended results for.
        /// When present, return hour-by-hour data for the next 168 hours, instead of the next 48.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, DateTimeOffset? dateTime, IList<Extend> extends )
        {
            return await GetWeatherForecastAsync( latitude, longitude, dateTime, GetDefaultValue<Unit>(), GetDefaultValue<Language>(), extends, null );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="excludes">Blocks that should be excluded from the API response.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, IList<Exclude> excludes )
        {
            return await GetWeatherForecastAsync( latitude, longitude, null, GetDefaultValue<Unit>(), GetDefaultValue<Language>(), null, excludes );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="dateTime">The date to retrieve data for.
        /// Returns the observed (in the past) or forecasted (in the future) hour-by-hour weather and daily weather conditions for a particular date.</param>
        /// <param name="excludes">Blocks that should be excluded from the API response.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude, double longitude, DateTimeOffset? dateTime, IList<Exclude> excludes )
        {
            return await GetWeatherForecastAsync( latitude, longitude, dateTime, GetDefaultValue<Unit>(), GetDefaultValue<Language>(), null, excludes );
        }

        /// <summary>
        ///     Retrieves the weather forecast data asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude to retrieve data for in degrees.</param>
        /// <param name="longitude">The longitude to retrieve data for in degrees.</param>
        /// <param name="dateTime">The date to retrieve data for.
        /// Returns the observed (in the past) or forecasted (in the future) hour-by-hour weather and daily weather conditions for a particular date.</param>
        /// <param name="unit">The units of weather conditions.</param>
        /// <param name="language">The language to use for 'Summary' properties.</param>
        /// <param name="extends"> The type of weather forecast to retrieve extended results for.
        /// When present, return hour-by-hour data for the next 168 hours, instead of the next 48.</param>
        /// <param name="excludes">Blocks that should be excluded from the API response.</param>
        /// <exception cref="WeatherForecastException">Throws if request to weather API is failed.</exception>
        /// <returns>The weather forecast response.</returns>
        public async Task<WeatherForecastResponse> GetWeatherForecastAsync( double latitude,
                                                                            double longitude,
                                                                            DateTimeOffset? dateTime,
                                                                            Unit unit,
                                                                            Language language,
                                                                            IList<Extend> extends,
                                                                            IList<Exclude> excludes )
        {
            var url = GetRequestUri( latitude, longitude, dateTime, unit, language, extends, excludes );
            var request = CreateWebRequest( url );

            try
            {
                using ( var response = (HttpWebResponse) request.GetResponse() )
                {
                    AssertResponseStatusCode( response );

                    ApiCallsMade = int.Parse( response.Headers["X-Forecast-API-Calls"] );
                    ApiResponseTime = response.Headers["X-Response-Time"];

                    using ( var stream = response.GetResponseStream() )
                    {
                        AssertStream( stream );

                        using ( var reader = new StreamReader( stream ) )
                        {
                            var jsonResponse = await reader.ReadToEndAsync().ConfigureAwait( false );

                            return JsonConvert.DeserializeObject<WeatherForecastResponse>( jsonResponse );
                        }
                    }
                }
            }
            catch ( WebException ex )
            {
                throw new WeatherForecastException( "Request failed.", ex );
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        ///     Gets the API request Uri.
        /// </summary>
        private string GetRequestUri( double latitude,
                                      double longitude,
                                      DateTimeOffset? dateTime,
                                      Unit unit,
                                      Language language,
                                      IList<Extend> extends,
                                      IList<Exclude> excludes )
        {
            return string.Format( dateTime.HasValue ? TIME_SPECIFIED_WEATHER_FORECAST_URL : CURRENT_WEATHER_FORECAST_URL,
                                 _apiKey,
                                 latitude,
                                 longitude,
                                 unit.GetSpecifiedValue(),
                                 language.GetSpecifiedValue(),
                                 extends.JoinEnumParameters(),
                                 excludes.JoinEnumParameters(),
                                 dateTime.HasValue ? dateTime.Value.ToUnixTimeSeconds().ToString() : string.Empty );
        }

        /// <summary>
        ///     Creates a new <see cref="HttpWebRequest" /> instance for the specified Uri resource.
        /// </summary>
        /// <param name="requestUri">Specified Uri resource.</param>
        private static HttpWebRequest CreateWebRequest( string requestUri )
        {
            var request = (HttpWebRequest) WebRequest.Create( requestUri );
            request.Method = "GET";
            request.Headers.Add( "Accept-Encoding", "gzip" );
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.ContentType = "application/json";

            return request;
        }

        #region Private Assert Methods

        /// <summary>
        ///     Checks if DarkSky API secret key is provided.
        /// </summary>
        /// <param name="apiKey">API key.</param>
        /// <exception cref="WeatherForecastException">Throws if API key is not provided (null, empty or white space string).</exception>
        private static void AssertApiKey( string apiKey )
        {
            if ( string.IsNullOrWhiteSpace( apiKey ) )
            {
                throw new WeatherForecastException( "DarkSky API secret key is not specified." );
            }
        }

        /// <summary>
        ///     Checks the status of the HTTP Web response.
        /// </summary>
        /// <param name="response">HTTP Web response resource.</param>
        /// <exception cref="WeatherForecastException">Throws if <see cref="HttpWebResponse.StatusCode" /> is not <see cref="HttpStatusCode.OK" /> (status not 200).</exception>
        private static void AssertResponseStatusCode( HttpWebResponse response )
        {
            if ( response.StatusCode != HttpStatusCode.OK )
            {
                throw new WeatherForecastException( response.StatusDescription );
            }
        }

        /// <summary>
        ///     Checks if IO Stream in not null.
        /// </summary>
        /// <param name="stream"></param>
        /// <exception cref="WeatherForecastException">Throws if IO Stream is null.</exception>
        private static void AssertStream( Stream stream )
        {
            if ( stream == null )
            {
                throw new WeatherForecastException( "Failed to receive Response." );
            }
        }

        #endregion

        #endregion
    }
}
