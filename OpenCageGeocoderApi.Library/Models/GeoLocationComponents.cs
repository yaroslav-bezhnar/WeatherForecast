using Newtonsoft.Json;
using OpenCageGeocoderApi.Library.Converters;

namespace OpenCageGeocoderApi.Library.Models
{
    /// <summary>
    ///     Represents a geographical location components class.
    /// </summary>
    public class GeoLocationComponents
    {
        #region Properties

        /// <summary>
        ///     Gets/Sets the geographical category of the location component.
        /// </summary>
        [JsonProperty( "_category" )]
        [JsonConverter(typeof ( DefaultUnknownEnumConverter<GeoCategoryType> ) )]
        public GeoCategoryType Category
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the geographical location type of the location component.
        /// </summary>
        [JsonProperty( "_type" )]
        [JsonConverter(typeof ( DefaultUnknownEnumConverter<GeoLocationType> ) )]
        public GeoLocationType Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the city of the geographical location component.
        /// </summary>
        public string City
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the city district of the geographical location component.
        /// </summary>
        [JsonProperty( "city_district" )]
        public string CityDistrict
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the country of the location component.
        /// </summary>
        public string Country
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the country code of the geographical location component.
        /// </summary>
        [JsonProperty( "country_code" )]
        public string CountryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the county of the location component.
        /// </summary>
        public string County
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the state of the location component.
        /// </summary>
        public string State
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the state district of the geographical location component.
        /// </summary>
        [JsonProperty( "state_district" )]
        public string StateDistrict
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the state code of the location component.
        /// </summary>
        [JsonProperty( "state_code" )]
        public string StateCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the political union of the location component.
        /// </summary>
        [JsonProperty( "political_union" )]
        public string PoliticalUnion
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the suburb of the geographical location component.
        /// </summary>
        public string Suburb
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the road of the location component.
        /// </summary>
        public string Road
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets/Sets the postal code of the geographical location component.
        /// </summary>
        public string Postcode
        {
            get;
            set;
        }

        #endregion
    }
}
