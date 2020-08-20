using Newtonsoft.Json;
using System;
using Wot.Replays.Models;

namespace Wot.Replays.Converters
{
    internal class MConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(M) || t == typeof(M?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<string>(reader);
            if (value == "XMQP")
            {
                return M.Xmqp;
            }
            throw new Exception("Cannot unmarshal type M");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (M)untypedValue;
            if (value == M.Xmqp)
            {
                serializer.Serialize(writer, "XMQP");
                return;
            }
            throw new Exception("Cannot marshal type M");
        }

        public static readonly MConverter Singleton = new MConverter();
    }
}
