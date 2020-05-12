using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Proszę podać nr PESEL: ");
            string wpisanyPesel = Console.ReadLine();

            // Walidacja nr PESEL pod kątem znaków

            while (Regex.IsMatch(wpisanyPesel, @"[a-zA-Z]") || wpisanyPesel.Length != 11)
            {
                Console.Write("Błędny format PESEL. Proszę podać prawidłowy nr PESEL: ");
                wpisanyPesel = Console.ReadLine();

            }

            // Jeśli null, pokaż komunikat

            if (SprawdzPesel(wpisanyPesel) != null)
            {
                SprawdzPesel(wpisanyPesel).WypiszDane();
            }
            else
            {
                Console.WriteLine("Niestety, wykryto błędną sumę kontrolną. Dane nie zostały przetworzone");
            }
            

            Console.ReadKey();
        }


        static DaneObywatela SprawdzPesel(string _pesel)
        {
            // Deklaracja zmiennych

            string rok;
            string miesiac;
            string dzien;
            uint plec;
            bool czyMezczyzna;
            int pelnyRok;
            string pelnaData;
            
            char[] tablicaznakow = _pesel.ToCharArray();
            int[] tablicaWartosci = new int[11];
            int sumaKontrolna = 0;

            Hashtable miesiaceT = new Hashtable() {
                { "01", "Styczeń" },
                { "02", "Luty" },
                { "03", "Marzec" },
                { "04", "Kwiecień" },
                { "05", "Maj"},
                { "06", "Czerwiec"},
                { "07", "Lipiec" },
                { "08", "Sierpień"},
                { "09", "Wrzesień" },
                { "10", "Październik"},
                { "11", "Listopad"},
                { "12", "Grudzień"} };

            // Parsowanie kazdej wartosci rok/miesiac/dzien/plec/sumak w celu dalszego przetworzenia/porownywania

            rok = _pesel.Remove(2, 9);
            miesiac = _pesel.Remove(0, 2).Remove(2, 7);
            dzien = _pesel.Remove(0, 4).Remove(2, 5);
            plec = Convert.ToUInt32(_pesel.Remove(0, 6).Remove(4, 1));

            // Sprawdzenie, czy obywatelem jest kobieta, czy mężczyzna

            czyMezczyzna = (plec % 2 > 0) ? true : false;

            // przypisanie kazdego znaku pesel do tablicy INT aby potem wykorzystać przy obliczaniu sumy kontrolnej

            tablicaWartosci[0] = (int)Char.GetNumericValue(tablicaznakow[0]);
            tablicaWartosci[1] = (int)Char.GetNumericValue(tablicaznakow[1]);
            tablicaWartosci[2] = (int)Char.GetNumericValue(tablicaznakow[2]);
            tablicaWartosci[3] = (int)Char.GetNumericValue(tablicaznakow[3]);
            tablicaWartosci[4] = (int)Char.GetNumericValue(tablicaznakow[4]);
            tablicaWartosci[5] = (int)Char.GetNumericValue(tablicaznakow[5]);
            tablicaWartosci[6] = (int)Char.GetNumericValue(tablicaznakow[6]);
            tablicaWartosci[7] = (int)Char.GetNumericValue(tablicaznakow[7]);
            tablicaWartosci[8] = (int)Char.GetNumericValue(tablicaznakow[8]);
            tablicaWartosci[9] = (int)Char.GetNumericValue(tablicaznakow[9]);
            tablicaWartosci[10] = (int)Char.GetNumericValue(tablicaznakow[10]);

            // Sprawdzanie liczby miesiąca, aby ustalić stulecie narodzin (1800/1900/2000/2100/2200 ?)

            if (tablicaWartosci[2] <= 1)
            {
                pelnyRok = Convert.ToInt32(rok) + 1900;
            }
            else if (tablicaWartosci[2] <= 3)
            {
                pelnyRok = Convert.ToInt32(rok) + 2000;

            }
            else if (tablicaWartosci[2] <= 5)
            {
                pelnyRok = Convert.ToInt32(rok) + 2100;

            }
            else if (tablicaWartosci[2] <= 7)
            {
                pelnyRok = Convert.ToInt32(rok) + 2200;

            }
            else if (tablicaWartosci[2] <= 9)
            {
                pelnyRok = Convert.ToInt32(rok) + 1800;

            }
            else {

                Console.WriteLine("Czyżby wystąpił błąd?");
                return null;

            }

            // Konstruktor pełnej daty do pokazania
            pelnaData = dzien + " " + miesiaceT[miesiac] + " " + pelnyRok.ToString();

            // Walidacja sumy kontrolnej

            tablicaWartosci[1] *= 3;
            tablicaWartosci[2] *= 7;
            tablicaWartosci[3] *= 9;
            tablicaWartosci[5] *= 3;
            tablicaWartosci[6] *= 7;
            tablicaWartosci[7] *= 9;
            tablicaWartosci[9] *= 3;

            for (int i = 0; i < 10; i++)
            {
                sumaKontrolna += tablicaWartosci[i];
            }
            sumaKontrolna = (10 - (sumaKontrolna % 10) ) % 10;

            if (sumaKontrolna == tablicaWartosci[10])
            {
                // Tworzenie obiektu z danymi obywatela
                DaneObywatela obywatel = new DaneObywatela(pelnaData, (czyMezczyzna) ? "mężczyzna" : "kobieta") ;

                return obywatel;
            }
            else
            {
                return null;
            }
            
        }

        

    }
    
    
}
