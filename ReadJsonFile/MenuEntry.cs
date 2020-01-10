using System.Collections.Generic;
using Newtonsoft.Json;

namespace ReadJsonFile
{
    public class MenuEntry
    {
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("items")]
        public List<ItemEntry> Items { get; set; }

    }
}