using System;


namespace ArithmaticOperators // 산술 연산자
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            Console.WriteLine($"a :{a}");
            //Console.WriteLine("a :{0}", a);

            int b = a - 100;
            Console.WriteLine($"b :{b}");

            int c = b * 10;
            Console.WriteLine($"c :{c}");

            double d = c/6.3;  // 정수로 나눌 경우 몫만, 소수로 나눌 경우 소수값으로 
            Console.WriteLine($"d :{d}");

            Console.WriteLine($"22 / 7 = {22/7}({22 % 7})");

        }
    }
}
