using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteOnepiece.Models
{
    public class Enfant
    {
        // Indique que cette propriété est la clé primaire
        [Key] 
        public int id { get; set; }

        // URL de l'image du personnage (peut être nul)
        public string? ImageURL { get; set; }

        // Description du personnage (peut être nul)
        public string? Description { get; set; }

        // Prime associée au personnage
        [Required]
        public double Prime { get; set; }

        // Nom du fruit du démon du personnage (peut être nul)
        public string? NomFruitDemon { get; set; }

        // Occupation du personnage avec longueur minimale et maximale
        [StringLength(20, MinimumLength = 5, ErrorMessage = "L'occupation doit comporter entre 5 et 20 caractères.")]
        [Required]
        public string? Occupation { get; set; }

        // Nom du personnage avec longueur minimale et maximale
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Le nom doit comporter entre 5 et 20 caractères.")]
        [Required]
        public string? Nom { get; set; }

        // Indique si le personnage est une vedette
        public bool EstVedette { get; set; }

        // Nom de l'équipage du personnage (peut être nul)
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Le nom de l'équipage doit comporter entre 5 et 20 caractères.")]
        public string? Equipage { get; set; }

        // Âge du personnage au début de l'histoire avec validation de la plage
        [Range(2, 800, ErrorMessage = "L'âge au début doit être compris entre 2 et 800.")]
        [Required]
        public int ageDebut { get; set; }

        // Âge actuel du personnage avec validation de la plage (peut être nul)
        [Range(2, 800, ErrorMessage = "L'âge actuel doit être compris entre 2 et 800.")]
        [Required]
        public int? agePrensent { get; set; }

        // Type de fruit du démon (peut être nul)
        public string? typeDeFruit { get; set; }

        // Propriété de navigation 
        [Display(Name = "Nom du parent")]
        [ForeignKey("Parent")] // Indique la clé étrangère pour la relation avec la classe Parent
        public int IdParent { get; set; }

        [ValidateNever] 
        public Parent Parent { get; set; } 
    }
}
