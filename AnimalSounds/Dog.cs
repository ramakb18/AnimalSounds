using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace AnimalSounds
{
    public class Dog : Animal
    {
        public Dog(string  name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{ Name} Says: Woof");
            using (var soundPlayer = new SoundPlayer("Sounds/dog.wav"))
            {
                soundPlayer.PlaySync();
            }    

        }
    }
}
