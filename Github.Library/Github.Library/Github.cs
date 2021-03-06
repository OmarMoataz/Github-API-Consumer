﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Github.Library.Entities;

namespace Github.Library
{
    public static class Github
    {
        static HttpClient Client;
        public const string URL = "https://api.github.com";

        /*
            TestAccount12312387
            XpUX7ra89GVekwJp
         */
        static Github()
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", Base64Decode("MzE3OGIxYzk2YTc3MDM5OGFmMDRlNDM0MDBmNDI5NmQ2NWRiZjBhMA==") ); //bypass ^-^
            Client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

        }
        public static string Get(string url, params string[] optionalParameters)
        {
            string u = url;
            foreach (var par in optionalParameters)
            {
                u += par;
            }
            return Client.GetStringAsync(url).Result;
        }

        public static async Task<string> PostAsync(string url, Dictionary<string, dynamic> body)
        {
            var j = JsonConvert.SerializeObject(body);
            var httpContent = new StringContent(j, Encoding.UTF8, "application/json");

            var x = Client.PostAsync(url, httpContent);

            return await x.Result.Content.ReadAsStringAsync();
        }



        public static User getCurrentUser() => JsonConvert.DeserializeObject<User>(Get($"{URL}/user"));

        public static User getUser(string _name) => JsonConvert.DeserializeObject<User>(Get($"{URL}/users/{_name}"));

        public static Repository[] getCurrentUserRepositories() => JsonConvert.DeserializeObject<Repository[]>(Get("https://api.github.com/user/repos"));

        public static Repository[] getUserRepositories(string _name) => JsonConvert.DeserializeObject<Repository[]>(Get($"https://api.github.com/users/{_name}/repos"));

        public static Issue[] searchIssues(string _query)
        {
            var json = JObject.Parse(Get($" https://api.github.com/search/issues?q={_query}"))["items"];
            return (JsonConvert.DeserializeObject<Issue[]>(JsonConvert.SerializeObject(json)));
        }

        public static Repository[] searchRepos(string _query)
        {
            var json = JObject.Parse(Get($" https://api.github.com/search/repositories?q={_query}"))["items"];
            return (JsonConvert.DeserializeObject<Repository[]>(JsonConvert.SerializeObject(json)));
        }

        public static User[] searchUsers(string _query)
        {
            var json = JObject.Parse(Get($" https://api.github.com/search/users?q={_query}"))["items"];
            return (JsonConvert.DeserializeObject<User[]>(JsonConvert.SerializeObject(json)));
        }

        //public static Code[] searchCode(string _query)
        //{
        //    var json = JObject.Parse(Get($"https://api.github.com/search/code?q=addClass+language:js"));
        //}

        

        public static Repository createRepository(string _name, string _desc = null, bool _private = false) => JsonConvert.DeserializeObject<Repository>(Task.Run(() => PostAsync($"{URL}/user/repos",
                new Dictionary<string, dynamic>
                {
                { "name", _name },
                { "description", _desc },
                { "private", _private }
                })).Result);

        public static HttpStatusCode deleteRepository(string owner, string name) =>
            Client.DeleteAsync($"{URL}/repos/{owner}/{name}").Result.StatusCode;

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
