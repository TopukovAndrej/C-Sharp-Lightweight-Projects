namespace PolymorphicZoo.Animals
{
    public abstract class Animal
    {
        public abstract void MakeSound();

        public virtual void Feed()
        {
            Console.WriteLine(value: "The animal is eating...");
        }
    }
}
