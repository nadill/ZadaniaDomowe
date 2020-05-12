using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Employee
    {
        private string imie;
        private string nazwisko;
        private float pensjaH;
        
        private float pieniadzeDoWyplaty;


        public Employee(string _imie, string _nazwisko, float _pensjaH)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            pensjaH = _pensjaH;

             

        }

        public void RegisterTime(float _czasPracy=0.0f)
        {
            float standardowyZarobek = (_czasPracy<=8) ? pensjaH * _czasPracy : pensjaH*8;
            float dodatkowyZarobek = (_czasPracy > 8) ? (pensjaH * 2) * (_czasPracy - 8) : 0;
            float dziennyZysk = standardowyZarobek + dodatkowyZarobek;
            pieniadzeDoWyplaty += dziennyZysk;

            switch (_czasPracy<=8)
            {
                case true:
                    Console.WriteLine($"\nPracownik {imie} {nazwisko} przepracował/a dzisiaj {_czasPracy} godzin. \nZarobił dzisiaj: {dziennyZysk} zł.");
                    break;

                case false:
                    Console.WriteLine($"\nPracownik {imie} {nazwisko} przepracował/a dzisiaj {_czasPracy} godzin. \nTego dnia wykonał też {_czasPracy-8} nadgodzin, zarabiając łącznie {dziennyZysk} zł, w tym {dodatkowyZarobek} zł premii za nadgodziny.");
                    break;
                default:
                    break;
            }
            
        }

        public void PaySalary()
        {
            Console.WriteLine($"\nPracownikowi: {imie} {nazwisko}, wypłacono łącznie: {pieniadzeDoWyplaty} zł za miesięczną pracę.");
            pieniadzeDoWyplaty = 0;
        }
    }
}
