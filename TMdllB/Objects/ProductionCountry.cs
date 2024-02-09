﻿using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class ProductionCountry
    {
        [JsonPropertyName("iso_3166_1")]
        public string Iso3166_1 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set;  }
    }
}
