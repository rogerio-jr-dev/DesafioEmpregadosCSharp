using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DesafioEmpregadosCSharp.Entities
{
    internal class Department
    {
        public string Name { get; set; }
        public int PayDay { get; set; }
        public Adress Adress { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Department() { }

        public Department(string name, int payDay, Adress adress)
        {
            Name = name;
            PayDay = payDay;
            Adress = adress;
        }
        //Adicionar um empregado
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        //Remover um empregado
        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
        public double PayRoll()
        {
            double sum = 0.0;
            foreach (Employee j in Employees)
            {
                sum += j.TotalSalary();
            }
            return sum;
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine("Departamento Vendas = R$ " + PayRoll().ToString("F2",CultureInfo.InvariantCulture));
            sb.AppendLine("Pagamento realizado no dia " + PayDay);
            sb.AppendLine("Funcionários: ");
            foreach (Employee j in Employees)
            {
                sb.AppendLine(j.ToString());
            }
            sb.AppendLine("Para dúvidas favor entrar em contato: " + Adress);

            return sb.ToString();
        }
    }
}
