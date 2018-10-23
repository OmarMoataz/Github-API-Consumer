using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GithubApi
{
    class Program
    {
        
            static HttpClient Client;
            public const string URL = "https://api.github.com/";
            static void Main(string[] args)
            {
                Client = new HttpClient();
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", "4115babe43140c5cd265720a9194e77eb4fba70c");
                Client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
            //Console.WriteLine(Client.GetStringAsync("https://api.github.com/user").Result);
            User s = getCurrentUser();

            Console.WriteLine(s.Login);


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

        public static string Post(string url, string body)
        {
            var buffer = System.Text.Encoding.UTF8.GetBytes(body);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return Client.PostAsync(url, byteContent).Result.ToString();
        }

        //public static User getCurrentUser()
        //{
        //    string response = Get("https://api.github.com/user");
            
        //    return JsonConvert.DeserializeObject<User>(response);
        //}

        public static User getCurrentUser() => JsonConvert.DeserializeObject<User>(Get($"{URL}/user"));

        public static User getUser(string name) => JsonConvert.DeserializeObject<User>(Get($"{URL}/user"));

    }


}
