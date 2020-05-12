using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok = 0;
            Console.Write("Podaj rok, aby obliczyć datę Wielkanocy: ");
            try
            {
                rok = Convert.ToInt32(Console.ReadLine());
            } catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            Wielkanoc wielkanoc = new Wielkanoc();
            Console.WriteLine(wielkanoc.ObliczWielkanoc(rok));


            Console.ReadKey();
        }
    }
}
