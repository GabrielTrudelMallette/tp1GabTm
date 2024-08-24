using Microsoft.AspNetCore.Mvc.Rendering;
using SiteOnepiece.Models;

namespace SiteOnepiece.ViewModels
{
    public class ParentVM
    {
        public Parent Parent { get; set; }

        public IEnumerable<SelectListItem> ParentList { get; set; }
    }
}
