using System.ComponentModel;
using WeatherForecast.DarkSkyApi.Library.Attributes;

namespace WeatherForecast.DarkSkyApi.Library
{
    /// <summary>
    ///     Languages that the service can return text summaries in.
    /// </summary>
    [DefaultValue( English )]
    public enum Language
    {
        [EnumStringValue( "ar" )]
        Arabic,

        [EnumStringValue( "az" )]
        Azerbaijani,

        [EnumStringValue( "be" )]
        Belarusian,

        [EnumStringValue( "bg" )]
        Bulgarian,

        [EnumStringValue( "bn" )]
        Bengali,

        [EnumStringValue( "bs" )]
        Bosnian,

        [EnumStringValue( "ca" )]
        Catalan,

        [EnumStringValue( "cs" )]
        Czech,

        [EnumStringValue( "da" )]
        Danish,

        [EnumStringValue( "de" )]
        German,

        [EnumStringValue( "el" )]
        Greek,

        [EnumStringValue( "en" )]
        English,

        [EnumStringValue( "eo" )]
        Esperanto,

        [EnumStringValue( "es" )]
        Spanish,

        [EnumStringValue( "et" )]
        Estonian,

        [EnumStringValue( "fi" )]
        Finnish,

        [EnumStringValue( "fr" )]
        French,

        [EnumStringValue( "he" )]
        Hebrew,

        [EnumStringValue( "hi" )]
        Hindi,

        [EnumStringValue( "hr" )]
        Croatian,

        [EnumStringValue( "hu" )]
        Hungarian,

        [EnumStringValue( "id" )]
        Indonesian,

        [EnumStringValue( "is" )]
        Icelandic,

        [EnumStringValue( "it" )]
        Italian,

        [EnumStringValue( "ja" )]
        Japanese,

        [EnumStringValue( "ka" )]
        Georgian,

        [EnumStringValue( "kn" )]
        Kannada,

        [EnumStringValue( "ko" )]
        Korean,

        [EnumStringValue( "kw" )]
        Cornish,

        [EnumStringValue( "lv" )]
        Latvian,

        [EnumStringValue( "ml" )]
        Malayam,

        [EnumStringValue( "mr" )]
        Marathi,

        [EnumStringValue( "nb" )]
        Norwegian,

        [EnumStringValue( "nl" )]
        Dutch,

        [EnumStringValue( "pa" )]
        Punjabi,

        [EnumStringValue( "pl" )]
        Polish,

        [EnumStringValue( "pt" )]
        Portuguese,

        [EnumStringValue( "ro" )]
        Romanian,

        [EnumStringValue( "ru" )]
        Russian,

        [EnumStringValue( "sk" )]
        Slovak,

        [EnumStringValue( "sl" )]
        Slovenian,

        [EnumStringValue( "sr" )]
        Serbian,

        [EnumStringValue( "sv" )]
        Swedish,

        [EnumStringValue( "ta" )]
        Tamil,

        [EnumStringValue( "te" )]
        Telugu,

        [EnumStringValue( "tet" )]
        Tetum,

        [EnumStringValue( "tr" )]
        Turkish,

        [EnumStringValue( "uk" )]
        Ukrainian,

        [EnumStringValue( "ur" )]
        Urdu,

        [EnumStringValue( "x-pig-latin" )]
        PigLatin,

        [EnumStringValue( "zh" )]
        ChineseSimplified,

        [EnumStringValue( "zh-tw" )]
        ChineseTraditional
    }
}
