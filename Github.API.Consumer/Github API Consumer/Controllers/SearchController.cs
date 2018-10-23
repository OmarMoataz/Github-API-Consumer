using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Github_API_Consumer.Controllers
{
    
    public class SearchController : Controller
    {
        GitHubClient github;
        public SearchController()
        {
           github = new GitHubClient(new ProductHeaderValue("MyTestApp"));
        }
        // GET: Search
        public ActionResult Index(string q = "")
        {
            if (q == "")
            {
                q = "default";
            }
            var request = new SearchRepositoriesRequest(q);
            var result = github.Search.SearchRepo(request);
            var r = result.Result.Items.Take(25);
            return View(r);
        }
    }
}