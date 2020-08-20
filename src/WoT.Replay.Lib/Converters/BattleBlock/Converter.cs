using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Wot.Replays.Converters
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                BonusBattlesConverter.Singleton,
                ServerSettingsRoamingConverter.Singleton,
                CodeElementConverter.Singleton,
                EventConverter.Singleton,
                LevelConverter.Singleton,
                MConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
