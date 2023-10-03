using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class HammerheadShark : SeaCreature
    {
        public HammerheadShark()
        {
            SpeciesName = "Hammerhead Shark";
            SpeciesClass = "Chondrichthyes";
            Description =
                "The known species range from 0.9 to 6.0 m in length and weigh 3–580 kg. They are usually light gray and\n" +
                "have a greenish tint. Their bellies are white, which allows them to blend into the background when viewed\n" +
                "from below and sneak up to their prey. Their heads have lateral projections that give them a hammer-like shape.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
