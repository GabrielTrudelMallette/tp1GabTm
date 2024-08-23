using Microsoft.AspNetCore.Mvc;
using SiteOnepiece.Models;
using SiteOnepiece.Models.data;
using SiteOnepiece.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace SiteOnepiece.Controllers
{
    public class EnfantController : Controller
    {
        private OnepieceDbContext DB { get; set; }

        public EnfantController(OnepieceDbContext pBd)
        {
            DB = pBd;
        }

        public IActionResult Recherche()
        {
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.EstFruitZoan = true;
            model.Criteres.EstFruitParamecia = true;
            model.Criteres.EstFruitLogia = true;
            model.Resultat = DB.Enfants.ToList();
            return View(model);
        }
        [Route("enfant/detail/{id:int}")]
        [Route("enfant/{id:int}")]
        [Route("{id:int}")]


        public IActionResult Detail(int id) 
        { 
            var EnfantRecherche = DB.Enfants.Where(d => d.id == id).SingleOrDefault(); 
            if (EnfantRecherche == null) 
            { 
                return View("NonTrouvé", "Le numéro de dresseur n'a pas été trouvé!"); }
            
            else 
            { 
                return View(EnfantRecherche); 
            } 
        }
        [Route("enfant/detail/{nom}")]
        [Route("detail/{nom}")]       
        public IActionResult Detail(string nom)
        {
            var EnfantRecherche = DB.Enfants.Where(d => d.Nom.ToUpper() == nom.ToUpper()).SingleOrDefault();
            if (EnfantRecherche == null) 
            {
                return View("NonTrouvé", "Le numéro de dresseur n'a pas été trouvé!"); 
            }
            else 
            {
                return View(EnfantRecherche); 
            }
        }
        [Route("/Enfant/Filtrer")]
        public IActionResult Filtrer(CritereRechercheViewModel criteres)
        {
            IEnumerable<Enfant> donnees = DB.Enfants;


            if (criteres.Nom  !=  null)
            {
                donnees = donnees.Where(j => j.Nom.ToUpper().Contains(criteres.Nom.ToUpper()));
            }
            if (!criteres.EstFruitLogia)
            {
                donnees = donnees.Where(j => j.IdParent != 1);
            }
            if (!criteres.EstFruitZoan) 
            {
                donnees = donnees.Where(j => j.IdParent != 2);
            }
            if (!criteres.EstFruitParamecia)
            {
                donnees = donnees.Where(j => j.IdParent != 3);
            }
            if (criteres.MinPrime != null)
            {
                donnees = donnees.Where(j => j.Prime <= criteres.MinPrime);
            }
            if (criteres.ChoixPourPersonnageVedette == "Peu importe")
            {
                donnees = donnees;
            }
            if (criteres.ChoixPourPersonnageVedette == "Oui")
            {
                donnees = donnees.Where(j => j.EstVedette);
            }
            if (criteres.ChoixPourPersonnageVedette == "Non")
            {
                donnees = donnees.Where(j => !j.EstVedette);
            }
            PageRechercheViewModel page = new PageRechercheViewModel();
            page.Criteres = criteres;
            page.Resultat = donnees.ToList();
            return View("Recherche", page );            
        }
        public IActionResult Index()
        {            
            List<Enfant> EnfantList = DB.Enfants.OrderBy(p => p.Nom).ToList();
            return View(EnfantList);
        }
        //get create
        [Route("Enfant/Create")]
        public IActionResult Create()
        {
<<<<<<< Updated upstream
            EnfantVM enfantVM = new EnfantVM();
            enfantVM.ParentList = DB.Parents.Select(p => new SelectListItem
            {
                Text = p.Nom,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text);

            return View(enfantVM);
        }

        [HttpPost("Enfant/Create")]
        public IActionResult Create(EnfantVM enfantVM)
=======
            //EnfantVM enfantVM = new EnfantVM();
            //enfantVM.EnfantList = DB.Enfants.Select(p => new SelectListItem
            //{
            //    Text = p.Nom,
            //    Value = p.id.ToString(),
            //}).OrderBy(p => p.Text);


            return View();
        }

        [HttpPost]
        public IActionResult Create(Enfant enfant)
>>>>>>> Stashed changes
        {            
            if (ModelState.IsValid)
            {
                DB.Enfants.Add(enfant);
                DB.SaveChanges();
                TempData["Ajouter"] = $" Pirate {enfant.Nom} Ajouter";
                return this.RedirectToAction("Index");
            }
<<<<<<< Updated upstream
            enfantVM.ParentList = DB.Parents.Select(p => new SelectListItem
            {
                Text = p.Nom,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text);
=======

            //ViewBag.EnfantList = DB.Enfants.Select(p => new SelectListItem
            //{
            //    Text = p.Nom,
            //    Value = p.id.ToString(),
            //}).OrderBy(p => p.Text);
>>>>>>> Stashed changes

            return View(enfant);
        }
        [Route("Enfant/Delete")]
        public IActionResult Delete(int id)
        {
            Enfant? enfant = DB.Enfants.Include(p => p.Parent).FirstOrDefault(p => p.id == id);
            if (enfant == null)
            {
                return NotFound();
            }
            return View(enfant);
        }

        [HttpPost("Enfant/Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            Enfant? enfant = DB.Enfants.Include(p => p.Parent).FirstOrDefault(p => p.id == id);
            if (enfant == null)
            {
                return NotFound();
            }
            DB.Enfants.Remove(enfant);
            DB.SaveChanges();
            TempData["Delete"] = $"Enfant {enfant.Nom} a été supprimer";
            return RedirectToAction("Index");
        }
        [Route("Enfant/Edit")]
        public IActionResult Edit(int id)
        {
            EnfantVM enfantVM = new EnfantVM();
            enfantVM.Enfant = DB.Enfants.Find(id);
            enfantVM.ParentList = DB.Parents.Select(p => new SelectListItem
            {
                Text = p.Nom,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text);

            

            return View(enfantVM);
        }

        [HttpPost("Enfant/Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EnfantVM enfantVM)
        {

            if (ModelState.IsValid)
            {
                DB.Enfants.Update(enfantVM.Enfant);
                DB.SaveChanges();
                TempData["Modifier"] = $"Enfant {enfantVM.Enfant.Nom} a été modifier";
                return this.RedirectToAction("index");
            }
            enfantVM.ParentList = DB.Parents.Select(p => new SelectListItem
            {
                Text = p.Nom,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text);

            return View(enfantVM);
        }
    }
}
