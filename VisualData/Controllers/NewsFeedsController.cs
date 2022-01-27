using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using VisualData.Models;

namespace VisualData.Controllers
{
    public class NewsFeedsController : Controller
    {
        public IActionResult Index()
        {
            var allDatasets = NewsData.GetNewsDatas(EnvironmentVariables.ApiNews);
            return View(allDatasets);
        }
    }
}