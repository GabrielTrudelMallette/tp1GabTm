using Microsoft.AspNetCore.Mvc;
using SiteOnepiece.Models;
using SiteOnepiece.ViewModels;

namespace SiteOnepiece.Controllers
{
    public class EnfantController : Controller
    {
        private BaseDeDonnées DB { get; set; }

        public EnfantController(BaseDeDonnées pBd)
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
            var dresseurRecherché = DB.Enfants.Where(d => d.id == id).SingleOrDefault(); 
            if (dresseurRecherché == null) 
            { 
                return View("NonTrouvé", "Le numéro de dresseur n'a pas été trouvé!"); }
            
            else 
            { 
                return View(dresseurRecherché); 
            } 
        }
        [Route("enfant/detail/{nom}")]
        [Route("detail/{nom}")]       
        public IActionResult Detail(string nom)
        {
            var dresseurRecherché = DB.Enfants.Where(d => d.Nom.ToUpper() == nom.ToUpper()).SingleOrDefault();
            if (dresseurRecherché == null) 
            {
                return View("NonTrouvé", "Le numéro de dresseur n'a pas été trouvé!"); 
            }
            else 
            {
                return View(dresseurRecherché); 
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

    }
}
