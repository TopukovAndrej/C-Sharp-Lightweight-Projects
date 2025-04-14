namespace PolymorphicZoo.Animals
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine(value: "The dog says woof...");
        }

        public override void Feed()
        {
            Console.WriteLine(value: "The dog is eating ham...");
        }
    }
}
