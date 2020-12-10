namespace Module2.Models.SafariPark.MammalsSection.PredatorsSection.FelineSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for Panther (пантер). Fourth iteration of inheritance.
    /// </summary>
    public class Irbis : Feline
    {
        private int lengthOfFur;

        public Irbis(string name, string phylum, int age, float weight, ClassOfAnimal classOfAnimal, SubclassOfAnimal subclassOfAnimal, GenusOfAnimal genusOfAnimal, TypeOfFood typeOfFood, bool isSocial, bool hasMane, int lengthOfFur)
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
            this.HasMane = hasMane;
            this.LengthOfFur = lengthOfFur;
        }

        public int LengthOfFur { get => this.lengthOfFur; set => this.lengthOfFur = value; }
    }
}
