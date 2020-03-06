using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WeatherForecast.DarkSkyApi.Library.Attributes;

namespace WeatherForecast.DarkSkyApi.Library.Helpers
{
    /// <summary>
    ///     Provides helper methods for <see cref="Enum" /> members.
    /// </summary>
    public static class EnumHelper
    {
        #region Public Methods

        public static TEnum GetDefaultValue<TEnum>() where TEnum : struct
        {
            var type = typeof( TEnum );
            var attributes = (DefaultValueAttribute[]) type.GetCustomAttributes( typeof( DefaultValueAttribute ), false );

            return attributes.Length > 0 ? (TEnum) attributes[0].Value : default;
        }

        public static string JoinEnumParameters<TEnum>( this IList<TEnum> values ) where TEnum : struct
            => values != null
                   ? string.Join( ',', values.Cast<Enum>().Select( GetSpecifiedValue ) )
                   : string.Empty;

        public static string GetSpecifiedValue( this Enum @enum )
        {
            var memberInfos = @enum.GetType().GetMember( @enum.ToString() );
            var attributes = memberInfos[0].GetCustomAttributes( typeof( EnumStringValueAttribute ), false );
            var specifiedValue = attributes.OfType<EnumStringValueAttribute>().FirstOrDefault()?.Value;

            return specifiedValue ?? @enum.ToString();
        }

        #endregion
    }
}
