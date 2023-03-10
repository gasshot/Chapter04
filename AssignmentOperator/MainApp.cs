using System;

namespace AssignmentOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a;
            a = 100;
            Console.WriteLine($"a = 100 : {a}");

            a += 90;  // a = a(100) + 90
            Console.WriteLine($"a += 90 : {a}"); //190

            a -= 80; // a = a(190) - 80
            Console.WriteLine($"a -= 80 : {a}"); //110

            a *= 70; // a = a(110) * 70
            Console.WriteLine($"a *= 80 : {a}"); // 7700

            a /= 60; // a = a(7700) / 60
            Console.WriteLine($"a /= 60 : {a}"); // 128

            a %= 50; // a = a(128) % 50
            Console.WriteLine($"a %= 50 : {a}"); // 28

            a &= 40; // a = a(28) & 40
            Console.WriteLine($"a &= 40 : {a}"); // 28 & 40 = 8 이진수

            a |= 30; // a = a(8) | 30
            Console.WriteLine($"a |= 30 : {a}"); // 8 | 30 = 30 이진수

            a ^= 20; // a = a(30) ^ 20
            Console.WriteLine($"a ^= 20 : {a}"); // 30 ^ 20 = 10 이진수

            a <<= 10; // a(10) 이진수 10번 오른쪽으로 밀어라
            Console.WriteLine($"a <<= 10 : {a}"); // 10 << 10 = 10240

            a >>= 1; // a(10240) 이진수 1번 왼쪽으로 밀어라
            Console.WriteLine($"a >>= 1 : {a}"); // 10240 >> 1 = 5120

        }
    }
}
