using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        [HttpPost]
        public IActionResult Results()
        {
            string searchType = Request.Form["searchType"];
            string searchTerm = Request.Form["searchTerm"];
            ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View("Index");
        }
    }
}
