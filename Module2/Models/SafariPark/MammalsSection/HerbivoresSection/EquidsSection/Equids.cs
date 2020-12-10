namespace Module2.Models.SafariPark.MammalsSection.HerbivoresSection.EquidsSection
{
    /// <summary>
    /// This is for Equids (непарнокопытные). Third iteration of inheritance.
    /// </summary>
    public class Equids : Herbivores
    {
        private bool isRiding;

        public bool IsRiding { get => this.isRiding; set => this.isRiding = value; }
    }
}
