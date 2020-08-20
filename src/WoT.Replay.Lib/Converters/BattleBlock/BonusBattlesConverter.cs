using Newtonsoft.Json;
using System;
using Wot.Replays.Models;

namespace Wot.Replays.Converters
{
    internal class BonusBattlesConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(BonusBattles) || t == typeof(BonusBattles?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Events>(reader);
                    return new BonusBattles { Events = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<BonusBattle[]>(reader);
                    return new BonusBattles { BonusBattleArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type BonusBattles");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BonusBattles)untypedValue;
            if (value.BonusBattleArray != null)
            {
                serializer.Serialize(writer, value.BonusBattleArray);
                return;
            }
            if (value.Events != null)
            {
                serializer.Serialize(writer, value.Events);
                return;
            }
            throw new Exception("Cannot marshal type BonusBattles");
        }

        public static readonly BonusBattlesConverter Singleton = new BonusBattlesConverter();
    }
}
