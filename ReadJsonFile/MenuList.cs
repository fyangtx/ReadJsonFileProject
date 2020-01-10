using Newtonsoft.Json;

namespace ReadJsonFile
{
    public class MenuList
    {
        [JsonProperty("menu")]
        public MenuEntry Menu { get; set; }
    }
}