using System;


namespace RelationalOperator //관계 연산자
{
    class MainApp
    {
        static void Main(string[] args)
        {
            bool a = 3 < 4;
            bool b = 3 > 4;

            Console.WriteLine($"3 > 4 : {3 > 4}"); // f
            Console.WriteLine($"3 >= 4 : {3 >= 4}"); // f
            Console.WriteLine($"3 < 4 : {3 < 4}"); // t
            Console.WriteLine($"3 <= 4 : {3 <= 4}"); // t
            Console.WriteLine($"3 == 4 : {3 == 4}"); //f
            Console.WriteLine($"3 != 4 : {3 != 4}"); //t

        }
    }
}
