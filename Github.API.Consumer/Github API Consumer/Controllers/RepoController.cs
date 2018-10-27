using System.Web.Mvc;
using GClient = Github.Library.Github;
using Github.Library.Entities;

namespace Github_API_Consumer.Controllers
{
    public class RepoController : Controller
    {

        public RepoController()
        {
            
        }
        // GET: Repo
        public ActionResult Index()
        {
            Repository[] repos = GClient.getCurrentUserRepositories();
            return View(repos);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, string type)
        {
            GClient.createRepository(name);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            var repos = GClient.getCurrentUserRepositories();
            return View(repos);
        }

        [HttpPost]
        public ActionResult Delete(string owner,string repo)
        {
            GClient.deleteRepository(owner, repo);
            return RedirectToAction("Index");
        }
    }
}