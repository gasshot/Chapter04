using System;

namespace ConditionalOperator  // 조건 연산자
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수"; // 10을 2로 나눈 나머지는 0 == 0 관계 참 짝수 : 홀수// 참 : 거짓
                                                             // 조건식 ? 2번째 매개변수 : 3번째 매개변수
            Console.WriteLine(result); // 짝수

           if(10%2==0)
            {
                Console.WriteLine("짝수");
            }
            
            
            
            int a = 30;

            string result2 = a == 30 ? "삼십" : "삼십아님";

            int b =10 ;
            
            string result3 = b == 30 ? "삼십" : "삼십아님";
        }
    }
}
