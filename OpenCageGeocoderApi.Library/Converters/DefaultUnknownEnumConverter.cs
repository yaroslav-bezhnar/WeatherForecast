using System;
using Newtonsoft.Json;

namespace OpenCageGeocoderApi.Library.Converters
{
    public class DefaultUnknownEnumConverter<TEnum> : JsonConverter<TEnum> where TEnum : struct
    {
        #region Public Methods

        /// <summary>
        ///     Reads the JSON representation of the object.
        /// </summary>
        public override TEnum ReadJson( JsonReader reader, Type objectType, TEnum existingValue, bool hasExistingValue, JsonSerializer serializer )
        {
            try
            {
                return serializer.Deserialize<TEnum>( reader );
            }
            catch
            {
                return default;
            }
        }

        /// <summary>
        ///     Writes the JSON representation of the object.
        /// </summary>
        public override void WriteJson( JsonWriter writer, TEnum value, JsonSerializer serializer ) => throw new NotImplementedException();

        #endregion
    }
}
