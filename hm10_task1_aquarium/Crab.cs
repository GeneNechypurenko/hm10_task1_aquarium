using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class Crab : SeaCreature
    {
        public Crab()
        {
            SpeciesName = "Crab";
            SpeciesClass = "Malacostraca";
            Description =
                "Crabs are generally covered with a thick exoskeleton, composed primarily of highly mineralized chitin,\n" +
                "and armed with a pair of claws. Crabs vary in size from the pea crab, a few millimeters wide, to the\n" +
                "Japanese spider crab, with a leg span up to 4 m. Several other groups of crustaceans with similar\n" +
                "appearances – such as king crabs and porcelain crabs – are not true crabs, but have evolved features\n" +
                "similar to true crabs through a process known as carcinisation.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
