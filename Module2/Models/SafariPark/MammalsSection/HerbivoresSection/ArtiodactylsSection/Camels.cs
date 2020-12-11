namespace Module2.Models.SafariPark.MammalsSection.HerbivoresSection.ArtiodactylsSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for Camels (верблюды). Fourth iteration of inheritance.
    /// </summary>
    public class Camels : Artiodactyls
    {
        private CountOfHumps countOfHumps;

        public Camels(string name, string phylum, int age, float weight, ClassOfAnimal classOfAnimal, SubclassOfAnimal subclassOfAnimal, GenusOfAnimal genusOfAnimal, TypeOfFood typeOfFood, CountOfFingers countOfFingers, bool spits, CountOfHumps countOfHumps)
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
            this.CountOfHumps = countOfHumps;
        }

        public CountOfHumps CountOfHumps { get => this.countOfHumps; set => this.countOfHumps = value; }
    }
}
