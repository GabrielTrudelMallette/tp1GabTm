using Microsoft.AspNetCore.Mvc.Rendering;
using SiteOnepiece.Models;

namespace SiteOnepiece.ViewModels
{
    public class EnfantVM
    {
        public Enfant Enfant { get; set; }  

        public IEnumerable<SelectListItem>? ParentList { get; set; }
    }
}
