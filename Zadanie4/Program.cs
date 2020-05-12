using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Jan", "Kowalski", 50f);
            emp1.RegisterTime(12.5f);

            Employee emp2 = new Employee("Justyna", "Marczak", 30.5f);
            emp2.RegisterTime();

            emp1.PaySalary();
            emp2.PaySalary();

            Console.ReadKey();
        }
    }
}
