using System.ComponentModel;

namespace SiteOnepiece.Models
{
    public class Enfant
    {
        /// <summary>
        /// propriété retournant le ID de l'enfant
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// propriété retournant le ID du parent
        /// </summary>
        public int IdParent { get; set; }

        /// <summary>
        /// propriété retournant le parent 
        /// </summary>
        public Parent ?Parent { get; set; }

        /// <summary>
        /// propriété retournant l'image
        /// </summary>
        public string ?ImageURL { get; set; }
        /// <summary>
        /// propriété retournant la description
        /// </summary>
        public string ?Description { get; set; }
        /// <summary>
        /// propriété retournant la prime de l'enfant
        /// </summary>
        public double Prime { get; set; }
        /// <summary>
        /// propriété retournant le fruit du demon de l'enfant
        /// </summary>
        public string ?NomFruitDemon { get; set; }
        /// <summary>
        /// propriété retournant l'occupation de l'enfant
        /// </summary>
        public string ?Occupation { get; set; }
        /// <summary>
        /// propriété retournant le nom de l'enfant
        /// </summary>
        public string ?Nom {  get; set; }
      
        /// <summary>
        /// propriété retournant si oui ou non l'enfant est vedette
        /// </summary>
        public bool EstVedette { get; set; }
        /// <summary>
        /// equipage de l'enfant
        /// </summary>
        public string ?Equipage { get; set; }
        /// <summary>
        /// propriété retournant l'age de l'enfant au debut de la serie
        /// </summary>

        public int ageDebut { get; set; }
        /// <summary>
        /// propriété retournant l'age de l'enfant a la fin de la serie
        /// </summary>
        public int agePrensent { get; set; }

        /// <summary>
        /// propriété retournant le type de fruit de l'enfant
        /// </summary>
        public string ?typeDeFruit { get; set; }



    }
}
