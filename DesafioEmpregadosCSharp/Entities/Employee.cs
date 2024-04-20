﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEmpregadosCSharp.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee() { }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public double TotalSalary()
        {
            return Salary;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
