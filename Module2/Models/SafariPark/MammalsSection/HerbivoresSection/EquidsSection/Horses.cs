namespace Module2.Models.SafariPark.MammalsSection.HerbivoresSection.EquidsSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for Horses (лошадей). Fourth iteration of inheritance.
    /// </summary>
    public class Horses : Equids
    {
        private Color color;

        public Horses(string name, string phylum, int age, float weight, ClassOfAnimal classOfAnimal, SubclassOfAnimal subclassOfAnimal, GenusOfAnimal genusOfAnimal, TypeOfFood typeOfFood, CountOfFingers countOfFingers, bool isRiding, Color color)
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
            this.Color = color;
        }

        public Color Color { get => this.color; set => this.color = value; }
    }
}
