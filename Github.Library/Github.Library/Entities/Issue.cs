using Newtonsoft.Json;

namespace Github.Library.Entities
{
    public class Issue
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("repository_url")]
        public string Repository_url { get; set; }
        [JsonProperty("labels_url")]
        public string Labels_url { get; set; }
        [JsonProperty("comments_url")]
        public string Comments_url { get; set; }
        [JsonProperty("events_url")]
        public string Events_url { get; set; }
        [JsonProperty("html_url")]
        public string Html_url { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("node_id")]
        public string Node_id { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }  
    }
}
