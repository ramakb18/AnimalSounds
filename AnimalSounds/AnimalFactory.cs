using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(enmAnimals animalType, string name)
        {
            return animalType switch
            {
                enmAnimals.Dog => new Dog(name),
                enmAnimals.Cat => new Cat(name),
                enmAnimals.Sheep => new Sheep(name),
                _ => throw new ArgumentException("Invalid animal type")
            };
        }

        public static Animal CreateAnimal(enmAnimals animalType)
        {
            string defaultName = animalType switch
            {
                enmAnimals.Dog => "Bella",
                enmAnimals.Cat => "Luna",
                enmAnimals.Sheep => "Daisy",
                _ => "Unknown"
            };

            return CreateAnimal(animalType, defaultName);
        }
    }
}
