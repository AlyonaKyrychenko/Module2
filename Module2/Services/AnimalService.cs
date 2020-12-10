namespace Module2.Services
{
    using System;
    using System.Collections;
    using Module2.Absrtactions;
    using Module2.Helpers.Comparers;
    using Module2.Models.SafariPark;

    public class AnimalService : IAnimalService
    {
        private Animals[] animalArray;

        public AnimalService()
        {
            this.animalArray = new Animals[0];
        }

        public Animals[] AnimalArray { get => this.animalArray; set => this.animalArray = value; }

        public void AddAnimal(Animals ob)
        {
            Array.Resize(ref this.animalArray, this.animalArray.Length + 1);
            this.animalArray[this.animalArray.Length - 1] = ob;
        }

        public void SortAnimalsByAge()
        {
            IComparer comparer = new AnimalComparerByAge();
            Array.Sort(this.animalArray, 0, this.animalArray.Length, comparer);
        }

        public void SortAnimalByWeight()
        {
            IComparer comparer = new AnimalComparerByWeight();
            Array.Sort(this.animalArray, 0, this.animalArray.Length, comparer);
        }
    }
}
