namespace Module2.Models.SafariPark.MammalsSection.PredatorsSection.CanineSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for Wolves (волки). Fourth iteration of inheritance.
    /// </summary>
    public class Wolves : Canine
    {
        private int countInPack;

        public Wolves(string name, string phylum, int age, float weight, ClassOfAnimal classOfAnimal, SubclassOfAnimal subclassOfAnimal, GenusOfAnimal genusOfAnimal, TypeOfFood typeOfFood, bool isSocial, bool canBeDomesticated, int countInPack)
        {
            this.Name = name;
            this.Phylum = phylum;
            this.Age = age;
            this.Weight = weight;
            this.ClassOfAnimal = classOfAnimal;
            this.SubclassOfAnimal = subclassOfAnimal;
            this.GenusOfAnimal = genusOfAnimal;
            this.TypeOfFood = typeOfFood;
            this.IsSocial = isSocial;
            this.CanBeDomesticated = canBeDomesticated;
            this.CountInPack = countInPack;
        }

        public int CountInPack { get => this.countInPack; set => this.countInPack = value; }
    }
}
