using System;


namespace test
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 8 >> 1; // 4  00000100
            int b = a >> 2; // 1  00000001 
            int c = b << 2; // 4  00000100

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
