using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class Squid : SeaCreature
    {
        public Squid()
        {
            SpeciesName = "Squid";
            SpeciesClass = "Cephalopoda";
            Description =
                "A squid is a mollusc with an elongated soft body, large eyes, eight arms, and two tentacles in the\n" +
                "superorder Decapodiformes, though many other molluscs within the broader Neocoleoidea are also called\n" +
                "squid despite not strictly fitting these criteria. Like all other cephalopods, squid have a distinct head,\n" +
                "bilateral symmetry, and a mantle. They are mainly soft-bodied, like octopuses, but have a small internal\n" +
                "skeleton in the form of a rod-like gladius or pen, made of chitin.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
