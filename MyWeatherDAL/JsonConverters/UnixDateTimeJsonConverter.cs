using MyWeatherDAL.Types;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyWeatherDAL.JsonConverters
{
    public class UnixDateTimeJsonConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetInt32(out int unixDateTime))
                    return UnixTime.FromUnixTime(unixDateTime);
            }
            throw new InvalidCastException($"Unable convert value {reader.GetString()} with type {reader.TokenType} to DateTime");
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) 
            => writer.WriteStringValue((value - UnixTime.Epoch).TotalSeconds.ToString());
    }
}
