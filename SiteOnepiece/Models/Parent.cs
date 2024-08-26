using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SiteOnepiece.Models
{
    public class Parent
    {
        [Key] // Indique que cette propriété est la clé primaire
        public int Id { get; set; }

        // Nom du parent avec une longueur maximale de 20 caractères
        [MaxLength(20, ErrorMessage = "Le nom ne peut pas dépasser 20 caractères.")]
        [Required]
        public string? Nom { get; set; }
        
        // Description du parent (peut être nul)
        public string? Description { get; set; }

        // Moyenne des primes associées au parent
        [Range(0, 1000000000000, ErrorMessage = "La prime moyenne doit être compris entre 0 et 1000000000000.")]
        public int MoyennePrime { get; set; }

        // URL de l'image du parent (peut être nul)
        public string? ImageURL { get; set; }

        // Nombre d'utilisateurs associés au parent
        public int nombreUtilisateur { get; set; }

        // Propriété de navigation 
        [ValidateNever] 
        public List<Enfant> Enfants { get; set; } = new List<Enfant>(); 
    }

}
