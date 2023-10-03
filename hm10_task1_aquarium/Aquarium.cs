using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal class Aquarium : SeaCreature, IEnumerable<SeaCreature>
    {
        private List<SeaCreature> creatures = new List<SeaCreature>();
        public void AddNewCreature(SeaCreature creature)
        {
            creatures.Add(creature);
        }
        public override void Info()
        {
            this.Info();
        }
        public IEnumerator<SeaCreature> GetEnumerator()
        {
            return creatures.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
