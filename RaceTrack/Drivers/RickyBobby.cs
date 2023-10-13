using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class RickyBobby : Driver
    {
        public RickyBobby(RaceCar raceCar) : base(raceCar)
        {
            Name = "Ricky Bobby";
            SkillLevel = 20;

        }
        public override void Drive()
        {
            Console.WriteLine($"{Name} throws it in gear. 5 seconds later... Yup, Flying Through The Air. This Is Not Good. ");
        }
    }
}
