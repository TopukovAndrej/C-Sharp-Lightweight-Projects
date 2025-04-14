namespace PolymorphicZoo.Farm
{
    using PolymorphicZoo.Animals;

    public class Farm
    {
        private readonly List<Animal> _animals;

        public IReadOnlyList<Animal> Animals => _animals.AsReadOnly();

        public Farm()
        {
            _animals = [];
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(item: animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            _animals.Remove(item: animal);
        }

        public void FeedAllAnimals()
        {
            foreach (var animal in _animals)
            {
                animal.Feed();
            }
        }
    }
}
