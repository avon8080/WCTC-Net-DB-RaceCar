using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class EleanorMustang : RaceCar
    
    {
        public EleanorMustang()
        {
            Name = "1967 Eleanor mustang";
            TopSpeed = 100;
        }
       
        public override void StartEngine()
        {
            Console.WriteLine($"The natural sound of the {Name} is just screaming American muscle. ");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} slows down from {TopSpeed}. Ends in {Position}");
        }

        public void GasIt()
        {
            if (Position < 10000 )
            {
                Console.WriteLine($"{Name} says: If your not first, your last and puts the pedal to the floor.");
            }
        }

        public override void StopEngine()
        {
            Console.WriteLine($"{Name} engine shuts off.");
        }
    }
}
