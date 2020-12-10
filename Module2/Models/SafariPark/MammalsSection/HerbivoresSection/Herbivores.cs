namespace Module2.Models.SafariPark.MammalsSection.HerbivoresSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for Herbivores (травоядные). Second iteration of inheritance.
    /// </summary>
    public class Herbivores : Mammals
    {
        private CountOfFingers countOfFingers;

        public CountOfFingers CountOfFingers { get => this.countOfFingers; set => this.countOfFingers = value; }
    }
}
