using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SiteOnepiece.Models
{
    public class Parent
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public int MoyennePrime { get; set; }
        public string? ImageURL { get; set; }
        public int nombreUtilisateur { get; set; }
        /// propriété de navigation
        [ValidateNever]
        public List<Enfant> Enfants { get; set; }
    }
}
