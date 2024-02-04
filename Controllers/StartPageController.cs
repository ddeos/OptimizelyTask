
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptimizelyTask.Models;

namespace OptimizelyTask.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        [HttpGet]
        public IActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    } 
}
