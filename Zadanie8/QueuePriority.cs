using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Zadanie8
{
    class QueuePriority
    {
        public Queue<Customer> queuePriority1;
        public Queue<Customer> queuePriority2;
        public Queue<Customer> queuePriority3;


        public QueuePriority()
        {
            queuePriority1 = new Queue<Customer>();
            queuePriority2 = new Queue<Customer>();
            queuePriority3 = new Queue<Customer>();

        }

        public void Enqueue(Customer _customer)
        {
            switch (_customer.Priority)
            {
                case 3:
                    queuePriority3.Enqueue(_customer);
                    
                    break;
                case 2:
                    queuePriority2.Enqueue(_customer);
                    break;
                case 1:
                    queuePriority1.Enqueue(_customer);
                    break;
                    //
                default:
                    queuePriority1.Enqueue(_customer);
                    break;
            }
            Console.WriteLine("Dodano do kolejki: {0}", _customer.PrintCustomerData());
            

        }

      

        public Customer Dequeue()
        {
            Customer dequeuedCustomer;

            if (queuePriority3.Count>0)
            {
                dequeuedCustomer = queuePriority3.Dequeue();
                Console.WriteLine($"Klient: {dequeuedCustomer.PrintCustomerData()} obsłużony. Priorytetem: {dequeuedCustomer.Priority}");
                return dequeuedCustomer;
            }
            else if (queuePriority2.Count > 0)
            {
                dequeuedCustomer = queuePriority2.Dequeue();
                Console.WriteLine($"Klient: {dequeuedCustomer.PrintCustomerData()} obsłużony. Priorytetem: {dequeuedCustomer.Priority}");

                return dequeuedCustomer;
            }
            else if (queuePriority1.Count > 0)
            {
                dequeuedCustomer = queuePriority1.Dequeue();
                Console.WriteLine($"Klient: {dequeuedCustomer.PrintCustomerData()} obsłużony. Priorytetem: {dequeuedCustomer.Priority}");

                return dequeuedCustomer;
            }
            else
            {
                Console.WriteLine("Kolejka jest już pusta, brak klientów.");
                return null;
            }
             
        }

        public void CountQueue()
        {
            int queueCount = 0;
            queueCount = queuePriority1.Count + queuePriority2.Count + queuePriority3.Count;
            Console.WriteLine();
            Console.WriteLine("Aktualna wielkość kolejki: {0}", queueCount);
            Console.WriteLine();
        }

        private Hashtable GenerateQueueStats()
        {
            Hashtable hashQueue = new Hashtable();

            hashQueue.Add("3", queuePriority3.Count);
            hashQueue.Add("2", queuePriority2.Count);
            hashQueue.Add("1", queuePriority1.Count);

            return hashQueue; 
        }

        public void PrintQueueStats()
        {
            Hashtable queueData = GenerateQueueStats();
            Console.WriteLine();
            Console.WriteLine("Liczba osób oczekujących w kolejce wg. priorytetu:");
            Console.WriteLine($"Priotyret: 3 \t Wielkość kolejki: {queueData["3"]}");
            Console.WriteLine($"Priotyret: 2 \t Wielkość kolejki: {queueData["2"]}");
            Console.WriteLine($"Priotyret: 1 \t Wielkość kolejki: {queueData["1"]}");
            Console.WriteLine();
        }

    }
}
