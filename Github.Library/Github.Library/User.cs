using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github.Library
{
    public class User
    {
        public User(string avatarUrl, string bio, string blog, int collaborators, string company, DateTimeOffset createdAt, int diskUsage, string email, int followers, int following, bool? hireable, string htmlUrl, int totalPrivateRepos, int id, string location, string login, string name, string nodeId, int ownedPrivateRepos, int privateGists, int publicGists, int publicRepos, AccountType type, string url)
        {
            AvatarUrl = avatarUrl;
            Bio = bio;
            Blog = blog;
            Collaborators = collaborators;
            Company = company;
            CreatedAt = createdAt;
            DiskUsage = diskUsage;
            Email = email;
            Followers = followers;
            Following = following;
            Hireable = hireable;
            HtmlUrl = htmlUrl;
            TotalPrivateRepos = totalPrivateRepos;
            Id = id;
            Location = location;
            Login = login;
            Name = name;
            NodeId = nodeId;
            OwnedPrivateRepos = ownedPrivateRepos;
            PrivateGists = privateGists;
            PublicGists = publicGists;
            PublicRepos = publicRepos;
            Type = type;
            Url = url;
        }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; protected set; }

        [JsonProperty("bio")]
        public string Bio { get; protected set; }

        [JsonProperty("blog")]
        public string Blog { get; protected set; }

        [JsonProperty("collaborators")]
        public int? Collaborators { get; protected set; }

        [JsonProperty("company")]
        public string Company { get; protected set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; protected set; }

        [JsonProperty("disk_usage")]
        public int? DiskUsage { get; protected set; }

        [JsonProperty("email")]
        public string Email { get; protected set; }

        [JsonProperty("followers")]
        public int Followers { get; protected set; }

        [JsonProperty("following")]
        public int Following { get; protected set; }

        [JsonProperty("hireable")]
        public bool? Hireable { get; protected set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; protected set; }

        [JsonProperty("id")]
        public int Id { get; protected set; }


        [JsonProperty("node_id")]
        public string NodeId { get; protected set; }

        [JsonProperty("location")]
        public string Location { get; protected set; }

        [JsonProperty("login")]
        public string Login { get; protected set; }

        [JsonProperty("name")]
        public string Name { get; protected set; }

        [JsonProperty("type")]
        public AccountType? Type { get; protected set; }

        [JsonProperty("owned_private_repos")]
        public int OwnedPrivateRepos { get; protected set; }

        [JsonProperty("private_gists")]
        public int? PrivateGists { get; protected set; }

        [JsonProperty("public_gists")]
        public int? PublicGists { get; protected set; }


        [JsonProperty("public_repos")]
        public int PublicRepos { get; protected set; }

        [JsonProperty("total_private_repos")]
        public int TotalPrivateRepos { get; protected set; }
        [JsonProperty("url")]
        public string Url { get; protected set; }
    }
}

