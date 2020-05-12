using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            // stworzenie instancji kolejki z priorytetem
            QueuePriority customerQueue = new QueuePriority();

            // stworzenie klientów i nadanie im priorytetów
            Customer klient1 = new Customer("Jan", "Kowalski", 2);
            Customer klient2 = new Customer("Anna", "Lewińska", 1);
            Customer klient3 = new Customer("Edyta", "Milewska", 3);
            Customer klient4 = new Customer("Piotr", "Kowal", 2);
            Customer klient5 = new Customer("Agnieszka", "Gołąb", 3);
            Customer klient6 = new Customer("Krzysztof", "Pacza", 2);
            Customer klient7 = new Customer("Krzysztof", "Kolo", 2);

            // Dodanie listy klientów do naszej kolejki
            customerQueue.Enqueue(klient1);
            customerQueue.Enqueue(klient2);
            customerQueue.Enqueue(klient3);
            customerQueue.Enqueue(klient4);
            customerQueue.Enqueue(klient5);
            Console.WriteLine();
            customerQueue.CountQueue();

            // Dodanie nowych klientow
            customerQueue.Enqueue(klient6);
            customerQueue.Enqueue(klient7);
            Console.WriteLine();
            customerQueue.CountQueue();

            // zwrócenie danych statystycznych z bierzącej kolejki
            customerQueue.PrintQueueStats();

            // obsłużenie Klientów według ich priorytetów
            customerQueue.Dequeue();
            customerQueue.Dequeue();
            customerQueue.Dequeue();

            customerQueue.CountQueue();
            customerQueue.PrintQueueStats();







            Console.ReadKey();
        }
    }
}
