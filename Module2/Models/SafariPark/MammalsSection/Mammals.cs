namespace Module2.Models.SafariPark.MammalsSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for mammals (млекопитающие). First iteration of inheritance.
    /// </summary>
    public class Mammals : Animals
    {
        private TypeOfFood typeOfFood;

        public TypeOfFood TypeOfFood { get => this.typeOfFood; set => this.typeOfFood = value; }
    }
}
