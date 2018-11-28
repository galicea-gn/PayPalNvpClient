using Newtonsoft.Json;
using PayPalNvpClient.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Helpers
{
    public class StringEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsSubclassOf(typeof(BaseStringEnumeration));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => JsonSerializer.CreateDefault().Deserialize(reader, objectType);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            
            writer.WriteValue(value.ToString());
        }
    }
}
