using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class SeaTurtle : SeaCreature
    {
        public SeaTurtle()
        {
            SpeciesName = "Sea Turtle";
            SpeciesClass = "Reptilia";
            Description =
                "In general, sea turtles have a more fusiform body plan than their terrestrial or freshwater\n" +
                "counterparts. This tapering at both ends reduces volume and means that sea turtles cannot retract\n" +
                "their head and limbs into their shells for protection, unlike many other turtles and tortoises.\n" +
                "However, the streamlined body plan reduces friction and drag in the water and allows sea turtles to swim\n" +
                "more easily and swiftly.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
