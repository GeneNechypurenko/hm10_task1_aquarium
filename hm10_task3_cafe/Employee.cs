using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task3_cafe
{
    internal abstract class Employee
    {
        protected string? Name { get; set; }
        protected int? Age { get; set; }
        protected string? Position { get; init; }
        public abstract void Info();
    }
}
