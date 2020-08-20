using Newtonsoft.Json;
using System;
using Wot.Replays.Models;

namespace Wot.Replays.Converters
{
    internal class ServerSettingsRoamingConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ServerSettingsRoaming) || t == typeof(ServerSettingsRoaming?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new ServerSettingsRoaming { Integer = integerValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<CodeElement[][]>(reader);
                    return new ServerSettingsRoaming { AnythingArrayArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ServerSettingsRoaming");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ServerSettingsRoaming)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.AnythingArrayArray != null)
            {
                serializer.Serialize(writer, value.AnythingArrayArray);
                return;
            }
            throw new Exception("Cannot marshal type ServerSettingsRoaming");
        }

        public static readonly ServerSettingsRoamingConverter Singleton = new ServerSettingsRoamingConverter();
    }
}
