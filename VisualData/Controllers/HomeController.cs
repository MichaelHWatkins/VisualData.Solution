using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using VisualData.Models;

namespace VisualData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allDatasets = AllStateData.GetAllStateDatas(EnvironmentVariables.ApiKey);
            return View(allDatasets);
        }

        public IActionResult Resources()
        {
            return View();
        }
    }
}