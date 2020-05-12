
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {

            List<StockData> data = ParseStockData();

            CheckMontlyMaxMin(data);

            Console.ReadKey();
        }

        class StockData {
            //tu pola opisujące dzienne notowanie
            public string dataNotowania;
            public string miesiac;
            public double kursOtwarcia;
            public double kursMax;
            public double kursMin;
            public double kursZamkniecia;
            public uint wolumenAkcji;

            
            // tu konsktruktor
            public StockData(string _data, double _kursO, double _kursMax, double _kursMin, double _kursZ, uint _wolumenA)
            {
                 dataNotowania = _data;
                 miesiac = dataNotowania.Remove(0, 5).Remove(2,3);
                 

                 kursOtwarcia = _kursO;
                 kursMax = _kursMax;
                 kursMin = _kursMin;
                 kursZamkniecia = _kursZ;
                 wolumenAkcji = _wolumenA;
            }
            // tu może jakieś metody
        }

        static void CheckMontlyMaxMin(List<StockData> _listaDat)
        {
            Console.WriteLine("Analiza najlepszych i najsłabszego kursu w każdym miesiącu:\n");
            double max = 0;
            double min = 0;
            string currentMonth="";
            int rozmiarListy = 0;

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

            foreach (var rekord in _listaDat)
            {
                if (currentMonth == "")
                {
                    currentMonth = rekord.miesiac;
                    max = rekord.kursMax;
                    min = rekord.kursMin;


                }
                else if (currentMonth == rekord.miesiac)
                {

                    //max = (max < rekord.kursMax) ? rekord.kursMax : max;
                    //min = (min > rekord.kursMin) ? rekord.kursMin : min;
                    if (max < rekord.kursMax) max = rekord.kursMax;
                    if (min > rekord.kursMin) min = rekord.kursMin;

                }
                else 
                {
                    Console.WriteLine($"{miesiaceT[currentMonth]}: Najlepszy kurs: {max}, Najsłabszy kurs: {min}");

                    currentMonth = rekord.miesiac;
                    max = rekord.kursMax;
                    min = rekord.kursMin;
                }
                
                rozmiarListy++;
            }
            
            if (rozmiarListy>=_listaDat.Count)
            {
                Console.WriteLine($"{miesiaceT[currentMonth]}: Najlepszy kurs: {max}, Najsłabszy kurs: {min}");
            }
        }
        static List<StockData> ParseStockData()
        {
            //bedzie zwracana lista obiektów klasy StockData
            List<StockData> result = new List<StockData>();

            // tu podajemy pełną ścieżkę do pliku CSV - jak nie bedzie tam pliku to dostaniecie wyjatek
            string path = @"C:\Users\Nadill\source\repos\ZadaniaDomowe\Zadanie6\mbk.csv";

            // metoda ReadAllText() odczytuje wskazany plik tekstowy do stringa
            // musi być using System.Text; 
            string content = File.ReadAllText(path, Encoding.UTF8);
            /*
             * więcej o metodzie Split()
             * https://docs.microsoft.com/pl-pl/dotnet/csharp/how-to/parse-strings-using-split
             */
            foreach (String line in content.Split('\n'))
            {
                /*
                 * wiersz jest parsowany zwracany jest jako tablica zawierająca na indeksie:
                 * 0 - data notowania
                 * 1 - kurs otwarcia
                 * 2 - kurs najwyszy
                 * 3 - kurs najnizszy
                 * 4 - kurs zamkniecia
                 * 5 - wolumen akcji
                 */ 
                string[] items = line.Trim().Split(',');

                // utworzyć obiekt przechowujący informacje na temat notowania w danym dniu
                // trzeba coś jeszcze z tym StockData zrobić
                
                string _data = items[0];
                double _kursO = double.Parse(items[1], CultureInfo.InvariantCulture);
                double _max = double.Parse(items[2], CultureInfo.InvariantCulture);
                double _min = double.Parse(items[3], CultureInfo.InvariantCulture);
                double _kursZ = double.Parse(items[4], CultureInfo.InvariantCulture);
                uint _wolumenA = Convert.ToUInt32(items[5]);
                    // Tutaj miałem problem z ./, bo kompilator nie rozpoznawal kropki w csv, 
                    // wiec znalazlem sposob poprzez InvariantCulture

                StockData sd = new StockData(_data, _kursO, _max, _min, _kursZ, _wolumenA);
                


                result.Add(sd);

            }
            Console.WriteLine("Dane miesięczne kursu MBK pobrane z pliku. \n");
            return result;

        }
    }
}
