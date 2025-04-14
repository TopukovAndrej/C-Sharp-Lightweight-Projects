namespace PolymorphicZoo.Animals
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine(value: "The cat says meow...");
        }

        public override void Feed()
        {
            Console.WriteLine(value: "The cat is eating fish...");
        }
    }
}
