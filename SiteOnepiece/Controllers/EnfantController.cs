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
        public IActionResult Create()
        {
            EnfantVM enfantVM = new EnfantVM();
            enfantVM.EnfantList = DB.Enfants.Select(p => new SelectListItem
            {
                Text = p.Nom,
                Value = p.id.ToString(),
            }).OrderBy(p => p.Text);


            return View(enfantVM);
        }

        [HttpPost]
        public IActionResult Create(EnfantVM enfantVM)
        {            
            if (ModelState.IsValid)
            {
                DB.Enfants.Add(enfantVM.Enfant);
                DB.SaveChanges();
                TempData["Ajouter"] = $" Pirate {enfantVM.Enfant.Nom} Ajouter";
                return this.RedirectToAction("Index");
            }

            ViewBag.EnfantList = DB.Enfants.Select(p => new SelectListItem
            {
                Text = p.Nom,
                Value = p.id.ToString(),
            }).OrderBy(p => p.Text);

            return View(enfantVM);
        }

        
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Enfant = DB.Enfants.Find(id);
            if (Enfant == null)
            {
                return NotFound();
            }

            ViewBag.EnfantList = DB.Enfants.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.id.ToString()
            });

            return View(Enfant);
        }

        [HttpPost]
        public IActionResult Edit(int id, Enfant enfant)
        {
            if (id != enfant.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               DB.Update(enfant);
                DB.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.EnfantList = DB.Enfants.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.id.ToString()
            });

            return View(enfant);
        }
    }
}
