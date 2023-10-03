using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class Lobster : SeaCreature
    {
        public Lobster()
        {
            SpeciesName = "Reef Lobster";
            SpeciesClass = "Malacostraca";
            Description =
                "Species occur from coral reefs at depths of less than 1 metre to rocky reefs at depths of 300 m.\n" +
                "They are brightly coloured, with stripes, rings, or spots. They are typically mainly red, orange,\n" +
                "purplish and white. Reef lobsters are small, nocturnal, and very timid. The species can be distinguished\n" +
                "by their colouration and morphology.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
