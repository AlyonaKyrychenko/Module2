namespace Module2.Models.SafariPark.MammalsSection.HerbivoresSection.ArtiodactylsSection
{
    /// <summary>
    /// This is for Artiodactyls (парнокопытные). Third iteration of inheritance.
    /// </summary>
    public class Artiodactyls : Herbivores
    {
        private bool spits;

        public bool Spits { get => this.spits; set => this.spits = value; }
    }
}
