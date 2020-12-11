namespace Module2.Models.SafariPark.MammalsSection.PredatorsSection.FelineSection
{
    /// <summary>
    /// This is for Feline (кошачьи). Third iteration of inheritance.
    /// </summary>
    public class Feline : Predators
    {
        private bool hasMane;

        public bool HasMane { get => this.hasMane; set => this.hasMane = value; }
    }
}
