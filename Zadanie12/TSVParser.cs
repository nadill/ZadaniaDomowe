using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    class TSVParser
    {

        string source;
        string content;
        List<Survivor> survivors = new List<Survivor>();

        public TSVParser()
        {
            source = @"C:\Users\Nadill\source\repos\ZadaniaDomowe\Zadanie12\titanic.tsv";
            try
            {
                content = File.ReadAllText(source, Encoding.UTF8);
            } catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            string[] lineSplit = content.Trim().Split('\n');
            
            for(int i=1; i < lineSplit.Length; i++)
            {
                string[] survivorData = lineSplit[i].Split('\t');

                survivors.Add(new Survivor(survivorData[3], survivorData[5], survivorData[2], survivorData[1]));
            }
            // Sortowanie listy
            survivors.Sort((x, y) => x.age.CompareTo(y.age));
            survivors.Reverse();

            // Print
            Console.WriteLine("{0,60}|{1,10}|{2,10}", "Name", "Age", "Pclass");
            int count = 0;
            foreach (Survivor survivor in survivors)
            {
                if (survivor.survived != 0 && count <10)
                {
                    Console.WriteLine("{0,60}|{1,10}|{2,10}", survivor.name, survivor.age, survivor.pclass);
                    count++;
                }
                else if (count >= 10)
                {
                    break;
                }
                
            }
            
        }



        
    }
}
