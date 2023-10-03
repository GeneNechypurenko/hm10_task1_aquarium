using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hm10_task3_cafe
{
    internal class Cook : Employee
    {
        public Cook(string name, int age)
        {
            Name = name;
            Age = age;
            Position = "Cook";
        }
        public override void Info()
        {
            Console.WriteLine($"{Name} : {Age} years : {Position};");
        }
    }
}
