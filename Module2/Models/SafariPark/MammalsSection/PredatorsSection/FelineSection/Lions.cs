namespace Module2.Models.SafariPark.MammalsSection.PredatorsSection.FelineSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for Lions (львов). Fourth iteration of inheritance.
    /// </summary>
    public class Lions : Feline
    {
        private bool isMale;

        public Lions(string name, string phylum, int age, float weight, ClassOfAnimal classOfAnimal, SubclassOfAnimal subclassOfAnimal, GenusOfAnimal genusOfAnimal, TypeOfFood typeOfFood, bool isSocial, bool hasMane, bool isMale)
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
            this.IsMale = isMale;
        }

        public bool IsMale { get => this.isMale; set => this.isMale = value; }
    }
}
