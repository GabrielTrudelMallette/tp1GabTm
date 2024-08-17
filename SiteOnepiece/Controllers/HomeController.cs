using Microsoft.AspNetCore.Mvc;
using SiteOnepiece.Models;

namespace SiteOnepiece.Controllers
{
    public class HomeController : Controller
    {
        private BaseDeDonnées DB { get; set; }

        public HomeController(BaseDeDonnées pBd)
        {
            DB = pBd;
        }
        public IActionResult Index()
        {
            
            return View(DB.Parents.ToList());
        }
    }
}
