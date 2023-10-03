using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task2_FootballClub
{
    internal class Goalkeeper : Player
    {
        public Goalkeeper(string name, int age)
        {
            Name = name;
            Age = age;
            Position = "Goalkeeper";
        }
        public override void Info()
        {
            Console.WriteLine($"{Name} : {Age} years : {Position};");
        }
    }
}
