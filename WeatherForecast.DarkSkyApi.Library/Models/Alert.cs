using System.Collections.Generic;
using Newtonsoft.Json;
using NodaTime;
using WeatherForecast.DarkSkyApi.Library.Converters;

namespace WeatherForecast.DarkSkyApi.Library.Models
{
    /// <summary>
    ///     Represents a class that contains a severe weather alert issued for the requested location.
    /// </summary>
    public class Alert
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets a detailed description of the alert.
        /// </summary>
        [JsonProperty( "description", Required = Required.Always )]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time at which the alert will expire.
        /// </summary>
        [JsonProperty( "expires", Required = Required.Always )]
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant Expires
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets a list of strings representing the names of the regions covered by this weather alert.
        /// </summary>
        [JsonProperty( "regions", Required = Required.Always )]
        public IList<string> Regions
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the severity of the weather alert.
        /// </summary>
        [JsonProperty( "severity", Required = Required.Always )]
        public Severity Severity
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the UNIX time at which the alert was issued.
        /// </summary>
        [JsonProperty( "time", Required = Required.Always )]
        [JsonConverter( typeof( UtcInstantJsonConverter ) )]
        public Instant Time
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets a brief description of the alert.
        /// </summary>
        [JsonProperty( "title", Required = Required.Always )]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets an HTTP(S) URI that one may refer to for detailed information about the alert.
        /// </summary>
        [JsonProperty( "uri", Required = Required.Always )]
        public string Uri
        {
            get;
            set;
        }

        #endregion
    }
}
