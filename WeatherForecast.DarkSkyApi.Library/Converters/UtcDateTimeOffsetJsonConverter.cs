using System;
using Newtonsoft.Json;

namespace WeatherForecast.DarkSkyApi.Library.Converters
{
    /// <summary>
    ///     Represents a class to convert JSON value to <see cref="DateTimeOffset" /> value.
    /// </summary>
    public class UtcDateTimeOffsetJsonConverter : JsonConverter<DateTimeOffset>
    {
        #region " Static Fields "

        /// <summary>
        ///     DateTime representing 0 UNIX Time: January 1, 1970, GMT.
        /// </summary>
        private static readonly DateTimeOffset _baseUnixTime = new DateTimeOffset( 1970, 1, 1, 0, 0, 0, new TimeSpan() );

        #endregion

        #region " Public Methods "

        /// <summary>
        ///     Reads the JSON representation of the object.
        /// </summary>
        public override DateTimeOffset ReadJson( JsonReader reader, Type objectType, DateTimeOffset existingValue, bool hasExistingValue, JsonSerializer serializer )
        {
            var time = serializer.Deserialize<long>( reader );

            return _baseUnixTime.AddSeconds( time );
        }

        /// <summary>
        ///     Writes the JSON representation of the object.
        /// </summary>
        public override void WriteJson( JsonWriter writer, DateTimeOffset value, JsonSerializer serializer ) => throw new NotImplementedException();

        #endregion
    }
}
