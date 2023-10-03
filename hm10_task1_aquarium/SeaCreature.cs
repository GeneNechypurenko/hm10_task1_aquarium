using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task1_aquarium
{
    internal abstract class SeaCreature
    {
        protected string? SpeciesName { get; init; }
        protected string? SpeciesClass { get; init; }
        protected string? Description { get; init; }
        public abstract void Info();
    }
}
