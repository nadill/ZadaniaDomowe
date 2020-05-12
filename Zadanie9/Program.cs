using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();

            Console.Write("Proszę o podanie ciągu liczb całkowitych, oddzielając je przecinkami: ");

            string ciagLiczb = Console.ReadLine();
            parser.ParseInput(ciagLiczb);

            Console.ReadKey();
        }
    }
}
