namespace Module2
{
    using System;
    using Module2.Enums;
    using Module2.Helpers.Extentions;
    using Module2.Models.SafariPark;
    using Module2.Models.SafariPark.MammalsSection.HerbivoresSection.ArtiodactylsSection;
    using Module2.Models.SafariPark.MammalsSection.HerbivoresSection.EquidsSection;
    using Module2.Models.SafariPark.MammalsSection.PredatorsSection.CanineSection;
    using Module2.Models.SafariPark.MammalsSection.PredatorsSection.FelineSection;
    using Module2.Services;

    public class Starter
    {
        public void Run()
        {
            const int ageOfPredator = 2;
            const string separator = "_______________________\n";
            AnimalService set1 = new AnimalService();
            set1.AddAnimal(new Camels("Camel Dromedary", "mammal", 5, 50.5F, ClassOfAnimal.Herbivore, SubclassOfAnimal.Artiodactyls, GenusOfAnimal.Camel, TypeOfFood.Bush, CountOfFingers.Two, true, CountOfHumps.One));
            set1.AddAnimal(new Foxes("Red fox", "mammal", 1, 3.5F, ClassOfAnimal.Predator, SubclassOfAnimal.Canine, GenusOfAnimal.Fox, TypeOfFood.Meet, false, false, true));
            set1.AddAnimal(new Lions("Lion", "mammal", 3, 70.2F, ClassOfAnimal.Predator, SubclassOfAnimal.Feline, GenusOfAnimal.Lion, TypeOfFood.Meet, true, true, true));
            set1.AddAnimal(new Horses("Horse of the apocalypse: Ruin", "mammal", 20, 120, ClassOfAnimal.Herbivore, SubclassOfAnimal.Equid, GenusOfAnimal.Horse, TypeOfFood.Grass, CountOfFingers.Two, true, Color.Red));
            set1.AddAnimal(new Irbis("Snow bars", "mammal", 1, 7, ClassOfAnimal.Predator, SubclassOfAnimal.Feline, GenusOfAnimal.Panther, TypeOfFood.Fish, false, false, 10));
            set1.AddAnimal(new Wolves("White wolf", "mammal", 7, 12, ClassOfAnimal.Predator, SubclassOfAnimal.Canine, GenusOfAnimal.Wolf, TypeOfFood.Meet, true, true, 5));

            Console.WriteLine("All animals in safari park:\n");
            foreach (Animals s in set1.AnimalArray)
            {
                Console.WriteLine($"{s.Name}: {s.Phylum}, age: {s.Age}, weight: {s.Weight}\nclass: {s.ClassOfAnimal}, subclass: {s.SubclassOfAnimal}, genus: {s.GenusOfAnimal}.\n");
            }

            Console.WriteLine(separator);

            Console.WriteLine("After sorting by weight:\n");
            set1.SortAnimalByWeight();
            foreach (Animals s in set1.AnimalArray)
            {
                Console.WriteLine($"{s.Name}: {s.Phylum}, age: {s.Age}, weight: {s.Weight}.");
            }

            Console.WriteLine(separator);

            Console.WriteLine("After sorting by age:\n");
            set1.SortAnimalsByAge();
            foreach (Animals s in set1.AnimalArray)
            {
                Console.WriteLine($"{s.Name}: {s.Phylum}, age: {s.Age}, weight: {s.Weight}.");
            }

            Console.WriteLine(separator);

            float weight = set1.CalcWeightForPredators();
            Console.WriteLine($"Summ of weight for {ClassOfAnimal.Predator}  = {weight}.");

            Console.WriteLine(separator);

            Animals[] predators = set1.FindAnimal(ClassOfAnimal.Predator);
            Console.WriteLine("Predators:\n");
            foreach (Animals predator in predators)
            {
                Console.WriteLine($"{predator.Name}: age: {predator.Age}, weight: {predator.Weight}.");
            }

            Console.WriteLine(separator);

            predators = set1.FindAnimal(ClassOfAnimal.Predator, ageOfPredator);
            if (predators.Length == 0)
            {
                Console.WriteLine($"No predators elder than {ageOfPredator}.");
            }
            else
            {
                Console.WriteLine($"Predators elder than {ageOfPredator}:\n");
                foreach (Animals predator in predators)
                {
                    Console.WriteLine($"{predator.Name}: age: {predator.Age}, weight: {predator.Weight}.");
                }
            }
        }
    }
}
