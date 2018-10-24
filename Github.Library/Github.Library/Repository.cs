using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github.Library
{
    public class Repository
    {
        public Repository() { }

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
        public string Url { get; protected set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; protected set; }

        [JsonProperty("id")]
        public long Id { get; protected set; }


        [JsonProperty("owner")]
        public User Owner { get; protected set; }
        [JsonProperty("name")]
        public string Name { get; protected set; }
        [JsonProperty("full_name")]
        public string FullName { get; protected set; }
        [JsonProperty("description")]
        public string Description { get; protected set; }
        [JsonProperty("homepage")]
        public string Homepage { get; protected set; }
        [JsonProperty("language")]
        public string Language { get; protected set; }
        [JsonProperty("private")]
        public bool Private { get; protected set; }

        [JsonProperty("forks_count")]
        public int ForksCount { get; protected set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; protected set; }
        [JsonProperty("open_issues_count")]
        public int OpenIssuesCount { get; protected set; }
        [JsonProperty("pushed_at")]
        public DateTimeOffset? PushedAt { get; protected set; }
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; protected set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; protected set; }

        [JsonProperty("parent")]
        public Repository Parent { get; protected set; }
        [JsonProperty("source")]
        public Repository Source { get; protected set; }

        [JsonProperty("has_issues")]
        public bool HasIssues { get; protected set; }

        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; protected set; }

        [JsonProperty("subscribers_count")]
        public int SubscribersCount { get; protected set; }
        [JsonProperty("size")]
        public long Size { get; protected set; }
    }
}
