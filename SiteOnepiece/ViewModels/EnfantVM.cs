using Microsoft.AspNetCore.Mvc.Rendering;
using SiteOnepiece.Models;

namespace SiteOnepiece.ViewModels
{
    public class EnfantVM
    {
        public Enfant Enfant { get; set; }  

        public IList<SelectListItem> selectListItem { get; set; }
    }
}
