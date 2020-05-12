using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            string wartoscInput;
            int wartoscInt;

            do
            {
                Console.Write("Witaj użytkowniku! Podaj liczbę pierwszą: ");
                wartoscInput = Console.ReadLine();
                
            } while (!Int32.TryParse(wartoscInput, out wartoscInt));
            // TryParse bardzo fajna metoda którą znalazłem, warta zapamietania na przyszłość :)
            
            if (CzyPierwsza(wartoscInt))
            {
                Console.WriteLine("Liczba {0} jest liczbą pierwszą.", wartoscInt);
            }
            else
            {
                Console.WriteLine("Liczba {0} nie jest liczbą pierwszą.", wartoscInt);
            }
            
            Console.ReadKey();
        }
        static bool CzyPierwsza( int _podanaLiczba)
        {
            if (_podanaLiczba == 2)
            {
                return true;
            }
            else if (_podanaLiczba == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(_podanaLiczba); i++)
                {
                    if (_podanaLiczba%i==0)
                    {
                        return false;

                    }
                }
                return true;
            }

        }

    }
}
