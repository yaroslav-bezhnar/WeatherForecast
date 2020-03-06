using Newtonsoft.Json;

namespace OpenCageGeocoderApi.Library.Models
{
    /// <summary>
    ///     Represents the geographical location type.
    /// </summary>
    public enum GeoLocationType
    {
        /// <summary>
        ///     Unknown geographical location type.
        /// </summary>
        Unknown,

        /// <summary>
        ///     Indicates the convenience location type.
        /// </summary>
        Convenience,

        /// <summary>
        ///     Indicates the bank location type.
        /// </summary>
        Bank,

        /// <summary>
        ///     Indicates the building location type.
        /// </summary>
        Building,

        /// <summary>
        ///     Indicates the road location type.
        /// </summary>
        Road,

        /// <summary>
        ///     Indicates the village location type.
        /// </summary>
        Village,

        /// <summary>
        ///     Indicates the neighborhood location type.
        /// </summary>
        [JsonProperty( "neighbourhood" )]
        Neighborhood,

        /// <summary>
        ///     Indicates the city location type.
        /// </summary>
        City,

        /// <summary>
        ///     Indicates the county location type.
        /// </summary>
        County,

        /// <summary>
        ///     Indicates the postcode location type.
        /// </summary>
        Postcode,

        /// <summary>
        ///     Indicates the terminated postcode location type.
        /// </summary>
        [JsonProperty( "terminated_postcode" )]
        TerminatedPostcode,

        /// <summary>
        ///     Indicates the state district location type.
        /// </summary>
        [JsonProperty( "state_district" )]
        StateDistrict,

        /// <summary>
        ///     Indicates the state location type.
        /// </summary>
        State,

        /// <summary>
        ///     Indicates the station location type.
        /// </summary>
        Station,

        /// <summary>
        ///     Indicates the region location type.
        /// </summary>
        Region,

        /// <summary>
        ///     Indicates the restaurant location type.
        /// </summary>
        Restaurant,

        /// <summary>
        ///     Indicates the island location type.
        /// </summary>
        Island,

        /// <summary>
        ///     Indicates the body of water location type.
        /// </summary>
        [JsonProperty( "body_of_water" )]
        BodyOfWater,

        /// <summary>
        ///     Indicates the country location type.
        /// </summary>
        Country,

        /// <summary>
        ///     Indicates the continent location type.
        /// </summary>
        Continent,

        /// <summary>
        ///     Indicates the fictitious location type.
        /// </summary>
        [JsonProperty( "ficticious" )]
        Fictitious
    }
}
