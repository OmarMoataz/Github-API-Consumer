using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    public class Repository
    {
        public Repository() { }

        public Repository(long id)
        {
            Id = id;
        }

        public Repository(string url, string htmlUrl, string cloneUrl, string gitUrl, string sshUrl, string svnUrl, string mirrorUrl, long id, string nodeId, User owner, string name, string fullName, string description, string homepage, string language, bool @private, bool fork, int forksCount, int stargazersCount, string defaultBranch, int openIssuesCount, DateTimeOffset? pushedAt, DateTimeOffset createdAt, DateTimeOffset updatedAt,  Repository parent, Repository source, bool hasIssues, bool hasWiki, bool hasDownloads, bool hasPages, int subscribersCount, long size, bool? allowRebaseMerge, bool? allowSquashMerge, bool? allowMergeCommit)
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

        public string Url { get; protected set; }

        public string HtmlUrl { get; protected set; }
        

        public long Id { get; protected set; }

        

        public User Owner { get; protected set; }

        public string Name { get; protected set; }

        public string FullName { get; protected set; }

        public string Description { get; protected set; }

        public string Homepage { get; protected set; }

        public string Language { get; protected set; }

        public bool Private { get; protected set; }
        

        public int ForksCount { get; protected set; }
       

        public string DefaultBranch { get; protected set; }

        public int OpenIssuesCount { get; protected set; }

        public DateTimeOffset? PushedAt { get; protected set; }

        public DateTimeOffset CreatedAt { get; protected set; }

        public DateTimeOffset UpdatedAt { get; protected set; }
        

        public Repository Parent { get; protected set; }

        public Repository Source { get; protected set; }
        

        public bool HasIssues { get; protected set; }
        

        public bool HasDownloads { get; protected set; }


        public int SubscribersCount { get; protected set; }

        public long Size { get; protected set; }

    }

}
    
