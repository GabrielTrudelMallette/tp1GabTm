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
        
        public IActionResult Create(Parent parent)
        {
            if (ModelState.IsValid)
            {
                DB.Parents.Add(parent);
                DB.SaveChanges();
                TempData["Ajouter"] = $" Pirate {parent.Nom} Ajouter";
                return this.RedirectToAction("Index");
            }

            ViewBag.ParentList = DB.Parents.Select(p => new SelectListItem
            {
                Text = p.Nom,
                Value = p.Id.ToString(),
            }).OrderBy(p => p.Text);

            return View(parent);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parent = DB.Parents.Find(id);
            if (parent == null)
            {
                return NotFound();
            }

            ViewBag.ParentList = DB.Parents.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.Id.ToString()
            });

            return View(parent);
        }

        [HttpPost]
        public IActionResult Edit(int id,Parent parent)
        {
            if (id != parent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                DB.Update(parent);
                DB.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.ParentList = DB.Parents.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.Id.ToString()
            });

            return View(parent);
        }
    }
}
