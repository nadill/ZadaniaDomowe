using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    public class TablicaSzachowa
    {
        
        public int wiersze;
        public int kolumny;
        Random losowePola = new Random();
        //public List<Pole> polaSzachowe;
        public int[,] tabPola;
        Skoczek skoczek;
        //int pozSkoczka;

        public TablicaSzachowa()
        {
            kolumny = losowePola.Next(5, 15);

            kolumny = losowePola.Next(5, 15);
            wiersze = losowePola.Next(5, 15);
            tabPola = new int[wiersze, kolumny];

            skoczek = new Skoczek(kolumny, wiersze);
            Console.WriteLine("Ustawienie startowe\n");
            RysujTablice();
            Console.WriteLine();
        }

        public void SymulujRuchySkoczka()
        {
            while (skoczek.mozeRuszac)
            {
                int celWie;
                int celKol;
                int proba = 0;
                for (int i = 0; proba < 6; i++)
                {
                    celWie = skoczek.aktualnyWie + skoczek.tabRuchow[i, 1];
                    celKol = skoczek.aktualnaKol + skoczek.tabRuchow[i, 0];

                    if (
                        skoczek.aktualnaKol + skoczek.tabRuchow[i, 0] >= 0 &&
                        skoczek.aktualnaKol + skoczek.tabRuchow[i, 0] < kolumny &&
                        skoczek.aktualnyWie + skoczek.tabRuchow[i, 1] >= 0 &&
                        skoczek.aktualnyWie + skoczek.tabRuchow[i, 0] < wiersze &&
                        celKol >=0 && celKol < kolumny &&
                        celWie >=0 && celWie < wiersze &&
                        tabPola[celWie, celKol] == 0
                        )
                    {
                        skoczek.aktualnyWie += skoczek.tabRuchow[i, 1];
                        skoczek.aktualnaKol += skoczek.tabRuchow[i, 0];

                        skoczek.ktoryRuch++;
                        tabPola[skoczek.aktualnyWie, skoczek.aktualnaKol] = skoczek.ktoryRuch;
                        proba++;
                        
                    }
                    
                }

                skoczek.mozeRuszac = false;
            }
            Console.WriteLine("\nSymulacja skoczka\n");
            Console.Write("\t");
            for (int z = 0; z < kolumny; z++)
            {
                Console.Write(z);
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < wiersze; i++)
            {
                Console.Write(i + "|\t");
                for (int j = 0; j < kolumny; j++)
                {
                    
                    Console.Write(tabPola[i, j]);
                }
                Console.WriteLine();
            }
        
        }

        public void RysujTablice()
        {
            Console.Write("\t");
            for (int z = 0; z < kolumny; z++)
            {
                Console.Write(z);
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < wiersze; i++)
            {
                Console.Write(i + "|\t");
                for (int j = 0; j < kolumny; j++)
                {
                    if (skoczek.aktualnaKol == j && skoczek.aktualnyWie == i)
                    {
                        tabPola[i, j] = skoczek.ktoryRuch;

                    }
                    
                    Console.Write(tabPola[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
