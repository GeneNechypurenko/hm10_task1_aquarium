using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace hm10_task3_cafe
{
    internal class Cafe : Employee, IEnumerable<Employee>
    {
        List<Employee> employees = new List<Employee>();
        public void AddNewEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public IEnumerator<Employee> GetEnumerator()
        {
            return employees.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override void Info()
        {
            throw new NotImplementedException();
        }
    }
}
