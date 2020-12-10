namespace Module2.Models.SafariPark.MammalsSection.PredatorsSection
{
    /// <summary>
    /// This is for Predators (хищники). Second iteration of inheritance.
    /// </summary>
    public class Predators : Mammals
    {
        private bool isSocial;

        public bool IsSocial { get => this.isSocial; set => this.isSocial = value; }
    }
}
