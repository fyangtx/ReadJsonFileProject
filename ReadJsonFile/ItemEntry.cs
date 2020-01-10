using System.Collections;
using Newtonsoft.Json;

namespace ReadJsonFile
{
    public class ItemEntry
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

    }
}