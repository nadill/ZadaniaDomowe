using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Skoczek
    {
        public Dictionary<int, int[,]> pulaRuchow = new Dictionary<int, int[,]>();
        public int[,] tabRuchow = new int[8, 2]
            {
                {-1,-2 },
                {1,-2 },
                {-1,2 },
                {1,2 },
                {2,-1 },
                {2,1 },
                {-2,-1 },
                {-2,1 }
            };
        public Dictionary<int, int[,]> historiaRuchow = new Dictionary<int, int[,]>();
        public int ktoryRuch = 1;
        Random random = new Random();
        public int aktualnaKol;
        public int aktualnyWie;
        public bool mozeRuszac = true;
        int wierszeSzachownicy;
        int kolumnySzachownicy;


        public Skoczek(int _kol, int _wie)
        {
            wierszeSzachownicy = _wie;
            kolumnySzachownicy = _kol;

            aktualnaKol = random.Next(0,_kol-1);
            aktualnyWie = random.Next(0, _wie-1);


        }

        public void Ruch()
        {

            
            
        }

    }
}
