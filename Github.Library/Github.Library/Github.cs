using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Github.Library
{
    public class Github
    {
        static HttpClient Client;
        public const string URL = "https://api.github.com";

        public Github()
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", "4115babe43140c5cd265720a9194e77eb4fba70c");
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

        public static User getUser(string _name) => JsonConvert.DeserializeObject<User>(Get($"{URL}/user/{_name}"));

        public static Repository[] getCurrentUserRepositories() => JsonConvert.DeserializeObject<Repository[]>(Get("https://api.github.com/user/repos"));

        public static Repository[] getUserRepositories(string _name) => JsonConvert.DeserializeObject<Repository[]>(Get($"https://api.github.com/users/{_name}/repos"));

        public static Repository createRepository(string _name, string _desc = null, bool _private = false) => JsonConvert.DeserializeObject<Repository>(Task.Run(() => PostAsync($"{URL}/user/repos",
            new Dictionary<string, dynamic>
            {
                { "name", _name },
                { "description", _desc },
                { "private", _private }
            })).Result);

        public static HttpStatusCode deleteRepository(string owner, string name) =>
            Client.DeleteAsync($"{URL}/repos/{owner}/{name}").Result.StatusCode;
    }
}
