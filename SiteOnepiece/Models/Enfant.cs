using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteOnepiece.Models
{
    public class Enfant
    {
        [Key]
        public int id { get; set; }

        public string? ImageURL { get; set; }
      
        public string? Description { get; set; }

        public double Prime { get; set; }

        public string? NomFruitDemon { get; set; }
        [StringLength(20, MinimumLength = 5)]
        public string? Occupation { get; set; }
        [StringLength(20, MinimumLength = 5)]
        public string? Nom { get; set; }

        public bool EstVedette { get; set; }

        public string? Equipage { get; set; }
        [Range(2, 800)]
        public int ageDebut { get; set; }
        [Range(2, 800)]
        public int agePrensent { get; set; }
       
        public string? typeDeFruit { get; set; }
        //propriété de navigation
        [ForeignKey("Parent")]
        public int IdParent { get; set; }
        [ValidateNever]
        public Parent Parent { get; set; }

    }
}
