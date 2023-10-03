using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class TigerShark : SeaCreature
    {
        public TigerShark()
        {
            SpeciesName = "Tiger Shark";
            SpeciesClass = "Chondrichthyes";
            Description =
                "The tiger shark is a solitary, mostly nocturnal hunter. It is notable for having the widest food\n" +
                "spectrum of all sharks, with a range of prey that includes crustaceans, fish, seals, birds, squid,\n" +
                "turtles, sea snakes, dolphins, and even other, smaller sharks. Tiger sharks have only one recorded natural\n" +
                "predator, the orca. It is considered a near threatened species because of finning and fishing by humans.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
