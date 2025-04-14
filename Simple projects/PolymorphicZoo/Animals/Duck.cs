namespace PolymorphicZoo.Animals
{
    public class Duck : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine(value: "The duck says quack...");
        }

        public override void Feed()
        {
            Console.WriteLine(value: "The duck is eating breadcrumbs...");
        }
    }
}
