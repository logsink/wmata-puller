﻿using Logship.WmataPuller.Config;
using System.Text.Json.Serialization;

namespace Logship.WmataPuller
{
    [JsonSerializable(typeof(IReadOnlyList<JsonLogEntrySchema>))]
    [JsonSerializable(typeof(string))]
    [JsonSerializable(typeof(bool))]
    [JsonSerializable(typeof(long))]
    [JsonSerializable(typeof(ulong))]
    [JsonSerializable(typeof(int))]
    [JsonSerializable(typeof(uint))]
    [JsonSerializable(typeof(DateTime))]
    [JsonSerializable(typeof(DateTimeOffset))]
    [JsonSerializable(typeof(double))]
    [JsonSerializable(typeof(float))]
    [JsonSerializable(typeof(Configuration))]
    internal partial class SourceGenerationContext : JsonSerializerContext
    {
    }
}
