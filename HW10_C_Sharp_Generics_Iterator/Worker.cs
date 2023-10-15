using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_C_Sharp_Generics_Iterator
{
    internal class Worker : IWorker
    {

        public int Salary { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public Worker(int salary, string name, string jobTitle)
        {
            Salary = salary;
            Name = name;
            JobTitle = jobTitle;
        }

        public string ShowInfo()
        {
            return ($"Name: {Name} \nJob title: {JobTitle} \nSalary{Salary.ToString()}");
        }
    }
}
