using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static int balance = 1000;

        static void Withdraw(object user)
        {
            Console.WriteLine($"{user} pul goturmek isteyir.");

            if (balance >= 200)
            {
                Thread.Sleep(500);

                balance -= 200;

                Console.WriteLine($"{user} 200 AZN goturdu.");
            }
            else
            {
                Console.WriteLine($"{user} ucun balans kifayet etmir.");
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Withdraw);
            Thread t2 = new Thread(Withdraw);
            Thread t3 = new Thread(Withdraw);

            t1.Start("Mahmud");
            t2.Start("Leyla");
            t3.Start("Ali");

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Son balans: " + balance);
        }
    }
}