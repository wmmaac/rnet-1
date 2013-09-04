﻿using System;
using System.Linq;

using Newtonsoft.Json;

namespace Rnet.Service.Objects
{

    class ObjectRefCollectionJsonConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ObjectRefCollection);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var objects = (ObjectRefCollection)value;

            writer.WriteStartObject();
            foreach (var o in objects)
            {
                writer.WritePropertyName(o.Id);
                writer.WriteStartObject();
                writer.WritePropertyName("Href");
                writer.WriteValue(o.Href);
                writer.WritePropertyName("Name");
                writer.WriteValue(o.Name);
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

    }

}
