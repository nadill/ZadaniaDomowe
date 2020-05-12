using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Wielkanoc
    {
        int a;
        int b;
        int c;
        int d;
        int e;
        int[,] zakresLat = new int[9,3] {
            { 1599, 15, 6 },
            { 1699, 22, 2 },
            { 1799, 23, 3 },
            { 1899, 23, 4 },
            { 2099, 24, 5 },
            { 2199, 24, 6 },
            { 2299, 25, 0 },
            { 2399, 26, 1 },
            { 2499, 25, 1 }
        };

        public string ObliczWielkanoc(int _rok)
        {
            int dzien;
            string miesiac;
            a = _rok % 19;
            b = _rok % 4;
            c = _rok % 7;
            int Amod;
            int Bmod;
            ObliczZakresLat(_rok, out Amod, out Bmod);

            d = (a * 19 + Amod) % 30;
            e = (2 * b + 4 * c + 6 * d + Bmod) % 7;

            if (d==29 && e == 6)
            {
                dzien = 19;
                miesiac = "kwiecień";
            }
            else if (d==28 && e==6)
            {
                dzien = 18;
                miesiac = "kwiecień";
            }
            else
            {
                dzien = 22 + d + e;
                if (dzien > 31)
                {
                    miesiac = "kwiecień";
                    dzien -= 31;
                }
                else
                {
                    miesiac = "marzec";
                }
            }

            
            
            

            return dzien.ToString() + " " + miesiac;
        }

        private void ObliczZakresLat(int _rok, out int _Amod, out int _Bmod)
        {
            int a=0;
            int b=0;
            for (int i = 0; i < zakresLat.Length; i++)
            {
                a = zakresLat[i, 1];
                b = zakresLat[i, 2];

                if (_rok <= zakresLat[i, 0]) break;
            }
            _Amod = a;
            _Bmod = b;


        }
    }
}
