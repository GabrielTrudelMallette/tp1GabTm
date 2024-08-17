namespace SiteOnepiece.ViewModels
{
    public class CritereRechercheViewModel
    {
        public string ChoixPourPersonnageVedette { get; set; }


        public bool EstFruitLogia { get; set; }

        public bool EstFruitZoan { get; set; }

        public bool EstFruitParamecia { get; set; }

        public int? MaxPrime { get; set; }

        public int? MinPrime { get; set; }

        public string? Nom { get; set; }

        public CritereRechercheViewModel() 
        {

        }
    }
}
