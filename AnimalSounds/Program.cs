namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = AnimalFactory.CreateAnimal(enmAnimals.Dog, "Bob");
            Animal cat = AnimalFactory.CreateAnimal(enmAnimals.Cat, "Luna");
            Animal sheep = AnimalFactory.CreateAnimal(enmAnimals.Sheep, "Lucy");

            Console.WriteLine("Animal Sounds:");
            dog.MakeSound();
            cat.MakeSound();
            sheep.MakeSound();
        }
    }
}
