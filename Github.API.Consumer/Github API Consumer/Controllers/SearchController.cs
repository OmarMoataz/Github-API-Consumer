using System.Web.Mvc;
using GClient = Github.Library.Github;
using Github.Library.Entities;

namespace Github_API_Consumer.Controllers
{
    
    public class SearchController : Controller
    {

        public SearchController()
        {
        }
        // GET: Search
        public ActionResult Index(string q = "")
        {
            if (q == "")
            {
                q = "default";
            }
            Issue[] issues = GClient.searchIssues(q);
            Repository[] repos = GClient.searchRepos(q);
            User[] users = GClient.searchUsers(q);
            ViewBag.repos = repos;
            ViewBag.issues = issues;
            ViewBag.users = users;
            ViewBag.query = q;
            return View();

        }

        public new ActionResult User(string q)
        {
            if (q == "")
            {
                q = "GithubAccount123123";
            }
            var r = GClient.getUser(q);
            return View(r);
        }
    }
}