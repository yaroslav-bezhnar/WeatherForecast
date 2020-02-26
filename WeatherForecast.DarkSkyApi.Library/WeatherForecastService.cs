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
    public class WeatherForecastService
    {
        #region Static Fields

        private const string CURRENT_WEATHER_FORECAST_URL = "https://api.darksky.net/forecast/{0}/{1},{2}?units={3}&lang={4}&extend={5}&exclude={6}";

        private const string TIME_SPECIFIED_WEATHER_FORECAST_URL = "https://api.darksky.net/forecast/{0}/{1},{2},{7}?units={3}&lang={4}&extend={5}&exclude={6}";

        #endregion

        #region Fields

        private readonly string _apiKey;

        #endregion

        #region Constructors

        public WeatherForecastService( string apiKey )
        {
            _apiKey = apiKey;
        }

        #endregion

        #region Properties
        public int? ApiCallsMade
        {
            get;
            private set;
        }

        public string ApiResponseTime
        {
            get;
            private set;
        }

        #endregion

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
                    ApiCallsMade = int.Parse( response.Headers["X-Forecast-API-Calls"] );
                    ApiResponseTime = response.Headers["X-Response-Time"];

                    using ( var stream = response.GetResponseStream() )
                    {
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
        private static HttpWebRequest CreateWebRequest( string requestUri )
        {
            var request = (HttpWebRequest) WebRequest.Create( requestUri );
            request.Method = "GET";
            request.Headers.Add( "Accept-Encoding", "gzip" );
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.ContentType = "application/json";

            return request;
        }
    }
}
