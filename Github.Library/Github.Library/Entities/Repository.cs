using Newtonsoft.Json;
using System;

namespace Github.Library.Entities
{
    public class Repository
    {
        public Repository() { }

        public Repository(string n) {
            Name = n;
            Private = false;
        }
        public Repository(long id)
        {
            Id = id;
        }

        public Repository(string url, string htmlUrl, string cloneUrl, string gitUrl, string sshUrl, string svnUrl, string mirrorUrl, long id, string nodeId, User owner, string name, string fullName, string description, string homepage, string language, bool @private, bool fork, int forksCount, int stargazersCount, string defaultBranch, int openIssuesCount, DateTimeOffset? pushedAt, DateTimeOffset createdAt, DateTimeOffset updatedAt, Repository parent, Repository source, bool hasIssues, bool hasWiki, bool hasDownloads, bool hasPages, int subscribersCount, long size, bool? allowRebaseMerge, bool? allowSquashMerge, bool? allowMergeCommit)
        {
            Url = url;
            HtmlUrl = htmlUrl;
            Id = id;
            Owner = owner;
            Name = name;
            FullName = fullName;
            Description = description;
            Homepage = homepage;
            Language = language;
            Private = @private;
            ForksCount = forksCount;
            DefaultBranch = defaultBranch;
            OpenIssuesCount = openIssuesCount;
            PushedAt = pushedAt;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Parent = parent;
            Source = source;
            HasIssues = hasIssues;
            HasDownloads = hasDownloads;
            SubscribersCount = subscribersCount;
            Size = size;
        }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }


        [JsonProperty("owner")]
        public User Owner { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("homepage")]
        public string Homepage { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("forks_count")]
        public int ForksCount { get; set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }
        [JsonProperty("open_issues_count")]
        public int OpenIssuesCount { get; set; }
        [JsonProperty("pushed_at")]
        public DateTimeOffset? PushedAt { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("parent")]
        public Repository Parent { get; set; }
        [JsonProperty("source")]
        public Repository Source { get; set; }

        [JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        [JsonProperty("subscribers_count")]
        public int SubscribersCount { get; set; }
        [JsonProperty("size")]
        public long Size { get; set; }
    }
}
