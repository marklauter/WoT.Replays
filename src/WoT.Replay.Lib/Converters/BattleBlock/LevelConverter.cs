using Newtonsoft.Json;
using System;
using Wot.Replays.Models;

namespace Wot.Replays.Converters
{
    internal class LevelConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Level) || t == typeof(Level?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<string>(reader);
            return value switch
            {
                "critical" => Level.Critical,
                "warning" => Level.Warning,
                _ => throw new Exception("Cannot unmarshal type Level"),
            };
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Level)untypedValue;
            switch (value)
            {
                case Level.Critical:
                    serializer.Serialize(writer, "critical");
                    return;
                case Level.Warning:
                    serializer.Serialize(writer, "warning");
                    return;
            }
            throw new Exception("Cannot marshal type Level");
        }

        public static readonly LevelConverter Singleton = new LevelConverter();
    }
}
