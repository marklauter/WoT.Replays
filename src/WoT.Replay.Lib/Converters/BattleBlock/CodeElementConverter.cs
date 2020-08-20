using Newtonsoft.Json;
using System;
using Wot.Replays.Models;

namespace Wot.Replays.Converters
{
    internal class CodeElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(CodeElement) || t == typeof(CodeElement?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new CodeElement { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new CodeElement { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type CodeElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CodeElement)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type CodeElement");
        }

        public static readonly CodeElementConverter Singleton = new CodeElementConverter();
    }
}
