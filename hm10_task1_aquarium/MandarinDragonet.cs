using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class MandarinDragonet : SeaCreature
    {
        public MandarinDragonet()
        {
            SpeciesName = "Mandarin Dragonet";
            SpeciesClass = "Ray-Finned Fish";
            Description =
                "Mandarinfish are reef dwellers, preferring sheltered lagoons and inshore reefs. While they are slow-moving\n" +
                "and fairly common within their range, they are not easily seen due to their bottom-feeding habit and their\n" +
                "small size (reaching only about 6 cm). They feed primarily on small crustaceans and other invertebrates.";
        }
        public override void Info()
        {
            Console.WriteLine($"{SpeciesName}, {SpeciesClass}\n{Description}\n");
        }
    }
}
