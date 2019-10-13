using System;

namespace Arvukolmnurk
{
    class Program
    {
        static void Main()
        {

            for (int i = 1; i <= 5 ; i++)
            {
                Console.WriteLine($"{i}");

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");   

                }
                
            }
            Console.ReadLine();
        }
    }
}
