using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Github_API_Consumer.Controllers
{
    public class RepoController : Controller
    {
        GitHubClient github;

        public RepoController()
        {
            github = new GitHubClient(new ProductHeaderValue("MyTestApp"));
            var basicAuth = new Credentials("GithubAccount123123", "SNeCDt24UvjwfgCh"); // NOTE: not real credentials
            github.Credentials = basicAuth;
        }
        // GET: Repo
        public ActionResult Index()
        {
            var repos = github.Repository.GetAllForCurrent();
            var r = repos.Result;
            return View(r);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, string type)
        {
            NewRepository repo = new NewRepository(name) { };
            if (type == "private")
                repo.Private = true;
            github.Repository.Create(repo);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            var repos = github.Repository.GetAllForCurrent();
            var r = repos.Result;
            return View(r);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            github.Repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}