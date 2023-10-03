using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task2_FootballClub
{
    internal class Defender : Player
    {
        public Defender(string name, int age)
        {
            Name = name;
            Age = age;
            Position = "Defender";
        }
        public override void Info()
        {
            Console.WriteLine($"{Name} : {Age} years : {Position};");
        }
    }
}
