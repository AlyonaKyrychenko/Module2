namespace Module2.Models.SafariPark.MammalsSection.PredatorsSection.CanineSection
{
    /// <summary>
    /// This is for Canine (собачьи). Third iteration of inheritance.
    /// </summary>
    public class Canine : Predators
    {
        private bool canBeDomesticated;

        public bool CanBeDomesticated { get => this.canBeDomesticated; set => this.canBeDomesticated = value; }
    }
}
