using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GClient = Github.Library.Github;

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
        public ActionResult Index(string q = "", string filter = "repositories")
        {
            if (q == "")
            {
                q = "default";
            }
            //return View(r);
            Github.Library.Issue[] issues = GClient.searchIssues(q);
            Github.Library.Repository[] repos = GClient.searchRepos(q);
            Github.Library.User[] users = GClient.searchUsers(q);
            ViewBag.repos = repos;
            ViewBag.issues = issues;
            ViewBag.users = users;
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