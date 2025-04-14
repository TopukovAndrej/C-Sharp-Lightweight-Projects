namespace PolymorphicZoo
{
    using PolymorphicZoo.Animals;

    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();

            Farm.Farm farm = new();

            int animalCounter = random.Next(minValue: 3, maxValue: 11);

            while (animalCounter > 0)
            {
                int randomNumber = random.Next(minValue: 1, maxValue: 4);

                if (randomNumber == 1)
                {
                    farm.AddAnimal(animal: new Cat());
                }
                else if (randomNumber == 2)
                {
                    farm.AddAnimal(animal: new Dog());
                }
                else
                {
                    farm.AddAnimal(animal: new Duck());
                }

                animalCounter--;
            }

            foreach (var farmAnimal in farm.Animals)
            {
                farmAnimal.MakeSound();
            }

            farm.FeedAllAnimals();
        }
    }
}
