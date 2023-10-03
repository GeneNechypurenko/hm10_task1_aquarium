using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task2_FootballClub
{
    internal abstract class Player
    {
        protected string? Name { get; set; }
        protected int? Age { get; set; }
        protected string? Position { get; init; }
        public abstract void Info();
    }
}