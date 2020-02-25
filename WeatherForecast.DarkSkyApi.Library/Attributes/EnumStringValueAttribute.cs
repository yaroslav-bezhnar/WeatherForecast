using System;

namespace WeatherForecast.DarkSkyApi.Library.Attributes
{
    /// <summary>
    ///     Represents an attribute class to provide string representation of enum value.
    /// </summary>
    [AttributeUsage( AttributeTargets.Field )]
    public class EnumStringValueAttribute : Attribute
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EnumStringValueAttribute" /> class.
        /// </summary>
        /// <param name="value">A string enum value</param>
        public EnumStringValueAttribute( string value )
        {
            Value = value;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets a string value of the enum value.
        /// </summary>
        public string Value
        {
            get;
        }

        #endregion
    }
}
