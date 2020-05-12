using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arabskie na Rzymskie //

            Console.Write("Podaj datę w formacie arabskim (1-3999): ");
            string dataString = Console.ReadLine();
            uint dataA;

            // Sprawdzanie poprawnosci wprowadzonych danych
            while (!UInt32.TryParse(dataString, out dataA))
            {
                Console.WriteLine("Data musi się składać z dodatniej liczby całkowitej!");
                Console.Write("Podaj datę w formacie arabskim (1-3999): ");
                dataString = Console.ReadLine();

            }            
            while (dataA>3999)
            {
                Console.Write("Zakres daty nie mieści się w zadaniu. \nProszę podać ponowenie nową datę w formacie arabskim (1-3999): ");
                dataA = Convert.ToUInt32(Console.ReadLine());
            }

            // Wywołanie metody ArabskieNaRzymskie i zwrocenie wyniku do konsoli //
            Console.WriteLine( "\nWynik: {0}", ArabskieNaRzymskie(dataA));


            // Rzymskie na Arabskie //

            Console.Write("\nPodaj datę w formacie rzymskim: ");
            dataString = Console.ReadLine();

            // Sprawdzanie poprawnosci wprowadzonych danych
            while (Regex.IsMatch(dataString.ToUpper(), @"\d|[QWERTYUOPASFGHJKZBN]+")) // Znalazłem zastosowanie Regex :)
            {
                Console.Write("\nZakres daty nie jest zgodny z zapisem rzymskim. Użyj wartości: I, V, X, L, C, D, M. \nPodaj nową datę: ");
                dataString = Console.ReadLine().ToUpper();

            }

            // Wywołanie metody RzymskieNaArabskie i zwrocenie wyniku do konsoli //
            Console.WriteLine( "Wynik: {0}", RzymskieNaArabskie(dataString) );

            Console.ReadKey();
        }

        static string ArabskieNaRzymskie(uint _dataArabska)
        {
            int dataArabska = (int)_dataArabska;
            int aktualnyZnak = 0;
            int petla;
             
            char[] dataRzymska = new char [20];

            if (dataArabska/1000>0)
            {
                petla = dataArabska / 1000;
                for (int z = 0; z < petla; z++)
                {

                    dataRzymska[aktualnyZnak] = 'M';
                    aktualnyZnak++;
                }
                dataArabska -= 1000 * petla;

            }
            if (dataArabska/100>0)
            {
                petla = dataArabska / 100;

                if (petla<4)
                {
                    for (int z = 0; z < petla; z++)
                    {
                        
                        dataRzymska[aktualnyZnak] = 'C';
                        aktualnyZnak++;
                    }
                }
                else if (petla == 4)
                {
                    dataRzymska[aktualnyZnak] = 'C';
                    aktualnyZnak++;
                    dataRzymska[aktualnyZnak] = 'D';
                    aktualnyZnak++;
                }
                else if (petla >4 && petla<9)
                {
                    dataRzymska[aktualnyZnak] = 'D';
                    aktualnyZnak++;
                    for (int z = 0; z < petla-4; z++)
                    {
                        dataRzymska[aktualnyZnak] = 'C';
                        aktualnyZnak++;
                    }
                }
                else if (petla == 9)
                {
                    
                    dataRzymska[aktualnyZnak] = 'C';
                    aktualnyZnak++;
                    dataRzymska[aktualnyZnak] = 'M';
                    aktualnyZnak++;
                }

                
                dataArabska -= 100 * petla;
            }
            if (dataArabska / 10 > 0)
            {
                petla = dataArabska / 10;

                if (petla < 4)
                {
                    for (int z = 0; z < petla; z++)
                    {
                        dataRzymska[aktualnyZnak] = 'X';
                        aktualnyZnak++;
                    }
                }
                else if (petla == 4)
                {
                    dataRzymska[aktualnyZnak] = 'X';
                    aktualnyZnak++; 
                    dataRzymska[aktualnyZnak] = 'L';
                    aktualnyZnak++;
                }
                else if (petla > 4 && petla < 9)
                {
                    
                    dataRzymska[aktualnyZnak] = 'L';
                    aktualnyZnak++;

                    for (int z = 0; z < petla - 5; z++)
                    {
                        dataRzymska[aktualnyZnak] = 'X';
                        aktualnyZnak++;

                    }
                }
                else if (petla == 9)
                {
                    dataRzymska[aktualnyZnak] = 'X';
                    aktualnyZnak++;
                    dataRzymska[aktualnyZnak] = 'C';
                    aktualnyZnak++;

                }
                dataArabska -= 10 * petla;
            }
            if (dataArabska / 1 > 0)
            {
                petla = dataArabska;

                if (petla < 4)
                {
                    for (int z = 0; z < petla; z++)
                    {
                        dataRzymska[aktualnyZnak] = 'I';
                        aktualnyZnak++;

                    }
                }
                else if (petla == 4)
                {
                    dataRzymska[aktualnyZnak] = 'I';
                    aktualnyZnak++;
                    dataRzymska[aktualnyZnak] = 'V';
                    aktualnyZnak++;

                }
                else if (petla > 4 && petla < 9)
                {
                    dataRzymska[aktualnyZnak] = 'V';
                    aktualnyZnak++;

                    for (int z = 0; z < petla - 5; z++)
                    {
                        dataRzymska[aktualnyZnak] = 'I';
                        aktualnyZnak++;

                    }
                }
                else if (petla == 9)
                {
                    dataRzymska.Append('I');
                    dataRzymska.Append('X');
                    dataRzymska[aktualnyZnak] = 'I';
                    aktualnyZnak++;
                    dataRzymska[aktualnyZnak] = 'X';
                    aktualnyZnak++;

                }
                dataArabska -= petla;
            }

            string wynik = new string(dataRzymska); // Tu się dowiedziałem jak sprawnie przypisac char[] do String :)
            return wynik;

            
        }

        static int RzymskieNaArabskie(string _dataRzymska)
        {
            string dataRzymska = _dataRzymska.ToUpper();
            uint dataArabska = 0;

            char rzymska1;
            char rzymska2;

            Dictionary<char, uint> slownikDaty = new Dictionary<char, uint>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

            for (int i = 0; i < dataRzymska.Length; i++)
            {
                if (i == dataRzymska.Length-1)
                {
                    rzymska1 = dataRzymska.ElementAt(i-1);
                    dataArabska += slownikDaty[rzymska1];
                }
                else
                {
                    rzymska1 = dataRzymska.ElementAt(i);
                    rzymska2 = dataRzymska.ElementAt(i + 1);
                    
                    if (slownikDaty[rzymska1] >= slownikDaty[rzymska2])
                    {
                        dataArabska += slownikDaty[rzymska1];
                    }
                    else
                    {
                        dataArabska += slownikDaty[rzymska2] - slownikDaty[rzymska1];
                        i++;
                    }
                }
            }
            return (int)dataArabska;
            
            

        }
    }
}
