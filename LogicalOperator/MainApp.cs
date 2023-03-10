using System;

namespace LogicalOperator // 논리 연산자
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing && ...");
            Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}"); // t 1*1
            Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}"); // f 1*0
            Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}"); // f 0*0
            Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}"); // f 0*1

            //Console.WriteLine("\n\n");

            Console.WriteLine("\nTesting || ...");
            Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}"); // t 1+1
            Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}"); // t 1+0
            Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}"); // f 0+0
            Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}"); // t 0+1

            //Console.WriteLine("\n\n");

            Console.WriteLine("\nTesting ! ...");
            Console.WriteLine($"!True : {!true}"); // f                ! : not으로 이해하쇼
            Console.WriteLine($"!False : {!false}"); // t

        }
    }
}
