namespace Module2.Models.SafariPark.MammalsSection.HerbivoresSection.EquidsSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for Donkeys (осликов). Fourth iteration of inheritance.
    /// </summary>
    public class Donkeys : Equids
    {
        private Hybrid hybrid;

        public Donkeys(string name, string phylum, int age, float weight, ClassOfAnimal classOfAnimal, SubclassOfAnimal subclassOfAnimal, GenusOfAnimal genusOfAnimal, TypeOfFood typeOfFood, CountOfFingers countOfFingers, bool isRiding, Hybrid hybrid)
        {
            this.Name = name;
            this.Phylum = phylum;
            this.Age = age;
            this.Weight = weight;
            this.ClassOfAnimal = classOfAnimal;
            this.SubclassOfAnimal = subclassOfAnimal;
            this.GenusOfAnimal = genusOfAnimal;
            this.TypeOfFood = typeOfFood;
            this.CountOfFingers = countOfFingers;
            this.IsRiding = isRiding;
            this.Hybrid = hybrid;
        }

        public Hybrid Hybrid { get => this.hybrid; set => this.hybrid = value; }
    }
}
