namespace SiteOnepiece.Models
{
    public class Parent
    {
        /// <summary>
        /// propriété retournant l'id du parent
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// propriété retournant le nom du parent
        /// </summary>
        public string ?Nom { get; set; }
        /// <summary>
        /// propriété retournant la liste d'enfants
        /// </summary>
        public List<Enfant> ?Enfants { get; set; }
        /// <summary>
        /// propriété retournant la Description du parent
        /// </summary>
        public string ?Description { get; set; }
        /// <summary>
        /// propriété retournant la prime moyenne des Parents
        /// </summary>
        public int MoyennePrime { get; set; }
        /// <summary>
        /// propriété retournant l'images du parents
        /// </summary>
        public string ?ImageURL { get; set; }
        /// <summary>
        /// propriété retournant le nombre d'utilisateur
        /// </summary>
        public int nombreUtilisateur { get; set; }
    }
}
