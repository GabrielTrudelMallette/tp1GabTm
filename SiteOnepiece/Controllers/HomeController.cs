using Microsoft.AspNetCore.Mvc;
using SiteOnepiece.Models;
using SiteOnepiece.Models.data;

namespace SiteOnepiece.Controllers
{
    public class HomeController : Controller
    {
        private OnepieceDbContext DB { get; set; }

        public HomeController(OnepieceDbContext pBd)
        {
            DB = pBd;
        }
        public IActionResult Index()
        {
            List<Parent> parent = DB.Parents.ToList();
            return View(parent);
        }
    }
}
