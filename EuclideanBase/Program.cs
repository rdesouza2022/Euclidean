using System;

namespace Euclidean
{
    class Program
    {

        static int euclideanL(int data1, int data2)
        {
            //Euclidean Algorithm using a while loop
            return 0;  //***** Delete this line and add your own code
        }

        static int euclideanR(int data1, int data2)
        {
            //Euclidean Algorithm using recursion
            return 0;  //***** Delete this line and add your own code
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input 2 Positive Integers (0 to exit)");
                Console.Write("Input Integer 1: ");
                int temp1 = int.Parse(Console.ReadLine());
                Console.Write("Input Integer 2: ");
                int temp2 = int.Parse(Console.ReadLine());
                if ((temp1 <= 0) || (temp2 <= 0)) break;

                int resultL = euclideanL(temp1, temp2);
                int resulrR = euclideanR(temp1, temp2);
                Console.WriteLine("GCD of {0} and {1}= Loop:{2}  Recursion:{3}",
                    temp1, temp2, resultL, resulrR);

                Console.WriteLine("\n");
            }
        }
    }
}
