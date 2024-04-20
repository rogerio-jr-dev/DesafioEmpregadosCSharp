using DesafioEmpregadosCSharp.Entities;
using System;
using System.Globalization;
namespace DesafioEmpregados
{
    class Program
    {
        static void Main(string[] args)
        {   //Variavel CI é para adicionar o padrão americando nos n° com decimais (.)
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.Write("Nome do departamento: ");
            string nameDep = Console.ReadLine();
            Console.Write("Dia do pagamento: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefone: ");
            string phone = Console.ReadLine();

            Adress adress = new Adress(email, phone);
            Department dept = new Department(nameDep, day, adress);

            Console.Write("Quantos funcionários tem o departamento? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Dados do funcionário {i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CI);

                Employee employee = new Employee(name, salary);
                dept.AddEmployee(employee);
            }
            Console.WriteLine();//Pular linha 
            Console.WriteLine("FOLHA DE PAGAMENTO:");
            Console.WriteLine(dept);
        }

    }
}
