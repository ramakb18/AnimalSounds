using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace AnimalSounds
{
    public class Sheep : Animal
    {
        public Sheep(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Baahh");
            using (var soundPlayer = new SoundPlayer("Sounds/sheep.wav"))
            {
                soundPlayer.PlaySync();
            }
        }
    }
}
