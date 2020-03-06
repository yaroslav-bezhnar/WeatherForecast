using Newtonsoft.Json;

namespace OpenCageGeocoderApi.Library.Models
{
    /// <summary>
    ///     Represents the geographical category type.
    /// </summary>
    public enum GeoCategoryType
    {
        /// <summary>
        ///     Unknown geographical category type.
        /// </summary>
        Unknown,

        /// <summary>
        ///     Indicates the agriculture category type.
        /// </summary>
        Agriculture,

        /// <summary>
        ///     Indicates the building category type.
        /// </summary>
        Building,

        /// <summary>
        ///     Indicates the commerce category type.
        /// </summary>
        Commerce,

        /// <summary>
        ///     Indicates the construction category type.
        /// </summary>
        Construction,

        /// <summary>
        ///     Indicates the education category type.
        /// </summary>
        Education,

        /// <summary>
        ///     Indicates the financial category type.
        /// </summary>
        Financial,

        /// <summary>
        ///     Indicates the government category type.
        /// </summary>
        Government,

        /// <summary>
        ///     Indicates the health category type.
        /// </summary>
        Health,

        /// <summary>
        ///     Indicates the industrial category type.
        /// </summary>
        Industrial,

        /// <summary>
        ///     Indicates the military category type.
        /// </summary>
        Military,

        /// <summary>
        ///     Indicates the natural or water category type.
        /// </summary>
        [JsonProperty( "natural/water" )]
        NaturalOrWater,

        /// <summary>
        ///     Indicates the outdoors or recreation category type.
        /// </summary>
        [JsonProperty( "outdoors/recreation" )]
        OutdoorsOrRecreation,

        /// <summary>
        ///     Indicates the place category type.
        /// </summary>
        Place,

        /// <summary>
        ///     Indicates the place of worship category type.
        /// </summary>
        [JsonProperty( "place_of_worship" )]
        PlaceOfWorship,

        /// <summary>
        ///     Indicates the postcode category type.
        /// </summary>
        Postcode,

        /// <summary>
        ///     Indicates the road category type.
        /// </summary>
        Road,

        /// <summary>
        ///     Indicates the social category type.
        /// </summary>
        Social,

        /// <summary>
        ///     Indicates the transportation category type.
        /// </summary>
        Transportation,

        /// <summary>
        ///     Indicates the travel or tourism category type.
        /// </summary>
        [JsonProperty( "travel/tourism" )]
        TravelOrTourism
    }
}
