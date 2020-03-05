using System;
using Newtonsoft.Json;
using NodaTime;

namespace WeatherForecast.DarkSkyApi.Library.Converters
{
    /// <summary>
    ///     Represents a class to convert JSON value to <see cref="Instant" /> value.
    /// </summary>
    public class UtcInstantJsonConverter : JsonConverter<Instant>
    {
        #region Public Methods

        /// <summary>
        ///     Reads the JSON representation of the object.
        /// </summary>
        public override Instant ReadJson(JsonReader reader, Type objectType, Instant existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var time = serializer.Deserialize<long>(reader);

            return Instant.FromUnixTimeSeconds(time);
        }

        /// <summary>
        ///     Writes the JSON representation of the object.
        /// </summary>
        public override void WriteJson(JsonWriter writer, Instant value, JsonSerializer serializer) => throw new NotImplementedException();

        #endregion
    }
}
