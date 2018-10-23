using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    public class Gist
    {
        public Gist() { }

        public Gist(string url, string id, string nodeId, string description, bool @public, User owner, int comments, string commentsUrl, string htmlUrl, string gitPullUrl, string gitPushUrl, DateTimeOffset createdAt, DateTimeOffset updatedAt)
        {
            Url = url;
            Id = id;
            NodeId = nodeId;
            Description = description;
            Public = @public;
            Owner = owner;
            Comments = comments;
            CommentsUrl = commentsUrl;
            HtmlUrl = htmlUrl;
            GitPullUrl = gitPullUrl;
            GitPushUrl = gitPushUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }


        public string Url { get; protected set; }


        public string Id { get; protected set; }

        public string NodeId { get; protected set; }


        public string Description { get; protected set; }


        public bool Public { get; protected set; }


        public User Owner { get; protected set; }


        public int Comments { get; protected set; }

        public string CommentsUrl { get; protected set; }

     
        public string HtmlUrl { get; protected set; }


        public string GitPullUrl { get; protected set; }

        public string GitPushUrl { get; protected set; }


        public DateTimeOffset CreatedAt { get; protected set; }

        public DateTimeOffset UpdatedAt { get; protected set; }
    }
}
