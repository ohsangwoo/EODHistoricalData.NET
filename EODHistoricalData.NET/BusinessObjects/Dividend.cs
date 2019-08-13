﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using EODHistoricalData.NET;
//
//    var dividend = Dividend.FromJson(jsonString);

namespace EODHistoricalData.NET
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Dividend
    {
        [JsonProperty("date")]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("declarationDate")]
        public DateTimeOffset? DeclarationDate { get; set; }

        [JsonProperty("recordDate")]
        public DateTimeOffset? RecordDate { get; set; }

        [JsonProperty("paymentDate")]
        public DateTimeOffset? PaymentDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class Dividend
    {
        public static Dictionary<string, Dividend> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, Dividend>>(json, EODHistoricalData.NET.ConverterDividend.Settings);
    }

    public static class SerializeDividend
    {
        public static string ToJson(this Dictionary<string, Dividend> self) => JsonConvert.SerializeObject(self, EODHistoricalData.NET.ConverterDividend.Settings);
    }

    internal static class ConverterDividend
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}