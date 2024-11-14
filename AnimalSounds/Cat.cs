using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace AnimalSounds
{

    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{ Name}Says: Meow");
            using (var soundPlayer = new SoundPlayer("Sounds/cat.wav"))
            {
                soundPlayer.PlaySync();
            }
        }
    }

}
