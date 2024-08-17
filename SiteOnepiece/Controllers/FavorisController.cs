using Microsoft.AspNetCore.Mvc;
using SiteOnepiece.Models;
using SiteOnepiece.Extensions;
using Microsoft.AspNetCore.Http;

namespace SiteOnepiece.Controllers
{
    public class FavorisController : Controller
    {
        private BaseDeDonnées DB { get; set; }

        public FavorisController(BaseDeDonnées pBd)
        {
            DB = pBd;
        }
        public IActionResult Index()
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }   
            var enfantsDeLaBD = DB.Enfants.Where(e => enfantIDs.Contains(e.id)).ToList();
            return View(enfantsDeLaBD);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AjouterUnEnfant(int id)
        {
            List<int> EnfantAjouter = HttpContext.Session.Get<List<int>>("enfantIDs");
            if (EnfantAjouter == null)
            {
                EnfantAjouter = new List<int>();
            }
            if (EnfantAjouter.Where(c => c == id).ToList() != null)
            {
                EnfantAjouter.Add(id);
                HttpContext.Session.Set<List<int>>("enfantIDs", EnfantAjouter);
            }
            
            
            return RedirectToAction("index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SupprimerUnEnfant(int id)
        {
            List<int> EnfantASupprimer = HttpContext.Session.Get<List<int>>("enfantIDs");
            if (EnfantASupprimer.Where(c => c == id).ToList() != null)
            {
                EnfantASupprimer.Remove(id);
            }
            
            HttpContext.Session.Set<List<int>>("enfantIDs", EnfantASupprimer);

            return RedirectToAction("index");
        }
    }
}
