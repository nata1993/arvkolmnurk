using System;

namespace Arvukolmnurk
{
    class Program
    {
        static void Main()
        {

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}");

                for (int j = 1; j <= i; j++)
                {
                    if (i == 5) //without break, the trianle ends with two 12345 lines at the end. This happens because at the end, i = 5 but j gets assigned as 1. 
                    {           //Since 1 is smaller than 5, which is stated in second for as j <= i, the second for loop continues until j reaches 5 at with point first loop
                        break;  //ends because i is incremented to 6 and since first loop is stated to end at 5 (i <= 5), then loop breaks and leaves us with two lines of 12345.
                    }           //Break breaks second loop by checking if the i is 5 and since after seconf for loop is nothing written, first loop is started again, i gets incremented to 6
                                // and then i <= 5 breaks first loop, since 6 is bigger than 5.
                    Console.Write($"{j}");
                }
                //here is nothing witten.
            }
        }
    }
}