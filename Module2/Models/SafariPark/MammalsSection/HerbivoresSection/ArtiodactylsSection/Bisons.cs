namespace Module2.Models.SafariPark.MammalsSection.HerbivoresSection.ArtiodactylsSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for Bisons (зубры). Fourth iteration of inheritance.
    /// </summary>
    public class Bisons : Artiodactyls
    {
        private bool dieOut;

        public Bisons(string name, string phylum, int age, float weight, ClassOfAnimal classOfAnimal, SubclassOfAnimal subclassOfAnimal, GenusOfAnimal genusOfAnimal, TypeOfFood typeOfFood, CountOfFingers countOfFingers, bool spits, bool dieOut)
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
            this.Spits = spits;
            this.DieOut = dieOut;
        }

        public bool DieOut { get => this.dieOut; set => this.dieOut = value; }
    }
}
