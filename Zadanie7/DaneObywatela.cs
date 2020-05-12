using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class DaneObywatela
    {
        private string dataUrodzenia;
        private string plec;

        public DaneObywatela(string _dataUrodzenia, string _plec)
        {
            dataUrodzenia = _dataUrodzenia;
            plec = _plec;
        }

        public void WypiszDane()
        {
            Console.WriteLine($"Data urodzenia: {dataUrodzenia}, płeć: {plec}");
        }


    }
}
