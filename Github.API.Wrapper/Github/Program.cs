using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Program
    {
        static HttpClient Client;
        static void Main(string[] args)
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", "4115babe43140c5cd265720a9194e77eb4fba70c");
            Client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
            Console.WriteLine(Client.GetStringAsync("https://api.github.com/user").Result);
        }
    }
}
