using Microsoft.Extensions.Primitives;
using SiteOnepiece.ViewModels;

namespace SiteOnepiece.ViewModels
{
    public class PageRechercheViewModel
    {
        public List<SiteOnepiece.Models.Enfant> Resultat { get; set; }
        public CritereRechercheViewModel Criteres {  get; set; }

        public PageRechercheViewModel() { }

    }  
}
