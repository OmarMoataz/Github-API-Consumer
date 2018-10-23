using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
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

        public string AvatarUrl { get; protected set; }


        public string Bio { get; protected set; }


        public string Blog { get; protected set; }

        public int? Collaborators { get; protected set; }


        public string Company { get; protected set; }

 
        public DateTimeOffset CreatedAt { get; protected set; }


        public int? DiskUsage { get; protected set; }


        public string Email { get; protected set; }


        public int Followers { get; protected set; }


        public int Following { get; protected set; }


        public bool? Hireable { get; protected set; }

        public string HtmlUrl { get; protected set; }

        public int Id { get; protected set; }


        public string NodeId { get; protected set; }


        public string Location { get; protected set; }


        public string Login { get; protected set; }

        public string Name { get; protected set; }

        public AccountType? Type { get; protected set; }


        public int OwnedPrivateRepos { get; protected set; }


        public int? PrivateGists { get; protected set; }

        public int PublicGists { get; protected set; }


        public int PublicRepos { get; protected set; }


        public int TotalPrivateRepos { get; protected set; }

        public string Url { get; protected set; }
    }
}
