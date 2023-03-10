using System;


namespace IncDecOperator //증가, 감소 연산자
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++); //후위 연산자
            Console.WriteLine(++a); //전위 연산자

            Console.WriteLine(a--); //후위 연산자
            Console.WriteLine(--a); //전위 연산자
        }
    }
}
