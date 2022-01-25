using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using VisualData.Models;

namespace VisualData.Controllers
{
    [EnableCors("MyAllowSpecificOrigins")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allDatasets = AllStateData.GetAllStateDatas(EnvironmentVariables.ApiKey);
            return View(allDatasets);
        }
    }
}