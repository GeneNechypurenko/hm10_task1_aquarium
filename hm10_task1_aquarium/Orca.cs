using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class Orca:SeaCreature
    {
        public Orca()
        {
            SpeciesName = "Orca";
            SpeciesClass = "Aquatic Mammal";
            Description =
                "The orca also called killer whale, is a toothed whale belonging to the oceanic dolphin family,\n" +
                "of which it is the largest member. It is the only extant species in the genus Orcinus and is recognizable\n" +
                "by its black-and-white patterned body. A cosmopolitan species, orcas can be found in all of the world's\n" +
                "oceans in a variety of marine environments, from Arctic and Antarctic regions to tropical seas.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
