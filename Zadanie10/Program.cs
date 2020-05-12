using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            TablicaSzachowa plansza = new TablicaSzachowa();

            plansza.SymulujRuchySkoczka();

            //plansza.RuchSkoczka();
            
            Console.ReadKey();
        }
    }
}
