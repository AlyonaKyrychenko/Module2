namespace Module2.Models.SafariPark.MammalsSection.PredatorsSection.CanineSection
{
    using Module2.Enums;

    /// <summary>
    /// This is for Foxes (лисы). Fourth iteration of inheritance.
    /// </summary>
    public class Foxes : Canine
    {
        private bool canChangeCoatColor;

        public Foxes(string name, string phylum, int age, float weight, ClassOfAnimal classOfAnimal, SubclassOfAnimal subclassOfAnimal, GenusOfAnimal genusOfAnimal, TypeOfFood typeOfFood, bool isSocial, bool canBeDomesticated, bool canChangeCoatColor)
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
            this.CanChangeCoatColor = canChangeCoatColor;
        }

        public bool CanChangeCoatColor { get => this.canChangeCoatColor; set => this.canChangeCoatColor = value; }
    }
}
