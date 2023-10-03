using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class AngelFish : SeaCreature
    {
        public AngelFish()
        {
            SpeciesName = "Angelfish";
            SpeciesClass = "Ray-Finned Fish";
            Description =
                "Angelfish vary in color and are very hardy fish. When kept in aquariums they can easily adapt to pH\n" +
                "and hardness changes in water and can handle conditions that are not considered to be perfect. They\n" +
                "are usually a long-living species and are easy to care for. They were very expensive in the aquarium\n" +
                "trade when first discovered, but have become more popular and therefore less pricey.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
