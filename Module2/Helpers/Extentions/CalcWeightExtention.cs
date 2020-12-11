namespace Module2.Helpers.Extentions
{
    using System;
    using Module2.Enums;
    using Module2.Models.SafariPark;
    using Module2.Services;

    public static class CalcWeightExtention
    {
        public static float CalcWeightForPredators(this AnimalService animalService)
        {
            float weight = 0;
            foreach (Animals ob in animalService.AnimalArray)
            {
                if (ob.ClassOfAnimal == ClassOfAnimal.Predator)
                {
                    weight += ob.Weight;
                }
            }

            return weight;
        }

        public static Animals[] FindAnimal(this AnimalService animalService, ClassOfAnimal classOfAnimal)
        {
            Animals[] result = new Animals[0];

            foreach (Animals ob in animalService.AnimalArray)
            {
                if (ob.ClassOfAnimal == classOfAnimal)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = ob;
                }
            }

            return result;
        }

        public static Animals[] FindAnimal(this AnimalService animalService, ClassOfAnimal classOfAnimal, int age)
        {
            Animals[] result = new Animals[0];

            foreach (Animals ob in animalService.AnimalArray)
            {
                if (ob.ClassOfAnimal == classOfAnimal && ob.Age > age)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = ob;
                }
            }

            return result;
        }
    }
}
