using Newtonsoft.Json;

namespace Github.Library.Entities
{
    class Code
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("sha")]
        public string Sha { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("git_url")]
        public string Git_url { get; set; }
        [JsonProperty("html_url")]
        public string Html_url { get; set; }
        [JsonProperty("Repository")]
        public Repository repository { get; set; }
    }
}
