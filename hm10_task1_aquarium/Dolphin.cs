using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class Dolphin : SeaCreature
    {
        public Dolphin()
        {
            SpeciesName = "Dolphin";
            SpeciesClass = "Aquatic Mammal";
            Description =
                "The dolphin weighs can range from 150 and 650 kg. It can reach a length of just over 4 meters.\n" +
                "Its color varies considerably, is usually dark gray on the back and lighter gray on the flanks.\n" +
                "Dolphins can live for more than 40 years. Females typically live 5–10 years longer than males.\n" +
                "Dolphins can jump to a height of 6 metres in the air.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
