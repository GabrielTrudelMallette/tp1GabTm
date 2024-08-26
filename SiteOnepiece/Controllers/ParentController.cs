using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SiteOnepiece.Models;
using SiteOnepiece.Models.data;
using SiteOnepiece.ViewModels;

namespace SiteOnepiece.Controllers
{
    public class ParentController : Controller
    {
        private OnepieceDbContext DB { get; set; }

        public ParentController(OnepieceDbContext pBd)
        {
            DB = pBd;
        }

        public IActionResult Index()
        {
            List<Parent> ParentList = DB.Parents.OrderBy(p => p.Nom).ToList();
            return View(ParentList);
        }

        //get create
        [Route("Parent/Create")]
        public IActionResult Create()
        {          
            return View();
        }

        [HttpPost("Parent/Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Parent parent)
        {
            if (ModelState.IsValid)
            {
                DB.Parents.Add(parent);
                DB.SaveChanges();
                TempData["Success"] = $" Pirate {parent.Nom} Ajouter";
                return this.RedirectToAction("Index");
            }          

            return View(parent);
        }

        public IActionResult Edit(int? id)
        {
            Parent parent = DB.Parents.Find(id);            

            return View(parent);
        }

        [HttpPost]
        public IActionResult EditPost(Parent parent)
        {          

            if (ModelState.IsValid)
            {
                DB.Update(parent);
                DB.SaveChanges();
                TempData["Success"] = $"Capitain {parent.Nom} a été modifier";
                return RedirectToAction(nameof(Index));
            }
           

            return View(parent);
        }
        public IActionResult Delete(int id)
        {
            Parent? parent = DB.Parents.Find(id);
            if (parent == null)
            {
                return NotFound();
            }

            return View(parent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            Parent? parent = DB.Parents.Find(id);
            if (parent == null)
            {
                return NotFound();
            }

            DB.Parents.Remove(parent);
            DB.SaveChanges();
            TempData["Success"] = $"Capitain {parent.Nom} has been removed";
            return RedirectToAction("Index");
        }
    }
}
