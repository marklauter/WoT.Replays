using Newtonsoft.Json;
using System;
using Wot.Replays.Models;

namespace Wot.Replays.Converters
{
    internal class EventConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Event) || t == typeof(Event?);
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
                "xmqp_death_zone_timer" => Event.XmqpDeathZoneTimer,
                "xmqp_hola" => Event.XmqpHola,
                "xmqp_minimap_click" => Event.XmqpMinimapClick,
                "xmqp_spotted" => Event.XmqpSpotted,
                "xmqp_vehicle_timer" => Event.XmqpVehicleTimer,
                _ => throw new Exception("Cannot unmarshal type Event"),
            };
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Event)untypedValue;
            switch (value)
            {
                case Event.XmqpDeathZoneTimer:
                    serializer.Serialize(writer, "xmqp_death_zone_timer");
                    return;
                case Event.XmqpHola:
                    serializer.Serialize(writer, "xmqp_hola");
                    return;
                case Event.XmqpMinimapClick:
                    serializer.Serialize(writer, "xmqp_minimap_click");
                    return;
                case Event.XmqpSpotted:
                    serializer.Serialize(writer, "xmqp_spotted");
                    return;
                case Event.XmqpVehicleTimer:
                    serializer.Serialize(writer, "xmqp_vehicle_timer");
                    return;
            }
            throw new Exception("Cannot marshal type Event");
        }

        public static readonly EventConverter Singleton = new EventConverter();
    }
}
