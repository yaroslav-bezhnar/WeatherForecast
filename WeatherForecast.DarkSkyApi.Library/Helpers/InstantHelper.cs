using System;
using NodaTime;

namespace WeatherForecast.DarkSkyApi.Library.Helpers
{
    /// <summary>
    ///     Provides helper methods for <see cref="Instant" /> members.
    /// </summary>
    public static class InstantHelper
    {
        #region Public Methods

        /// <summary>
        ///     Convert the timeline of <see cref="Instant" /> to a <see cref="OffsetDateTime" /> for a for the given IANA time zone.
        /// </summary>
        /// <param name="instant">A UNIX timeline of the <see cref="Instant" />.</param>
        /// <param name="timeZone">An IANA time zone string.</param>
        /// <returns>The <see cref="OffsetDateTime" /> representing the moment in time.</returns>
        public static OffsetDateTime ToLocalTime( this Instant instant, string timeZone )
        {
            if ( string.IsNullOrWhiteSpace( timeZone ) ) throw new ArgumentNullException( nameof( timeZone ), "The IANA time zone is not specified." );

            var zonedDateTime = instant.InZone( DateTimeZoneProviders.Tzdb[timeZone] );

            return zonedDateTime.ToOffsetDateTime();
        }

        #endregion
    }
}
