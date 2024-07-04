//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0704CSharp
//{
//    internal class MainApp
//    {
//        static void Divide (int num1, int num2)
//        {
//            if(num2 == 0)
//            {
//                throw new Exception("제수는 0으로 나눌수 없다");
//            }

//            Console.WriteLine($"나눗셈의 몫: {num1/num2}");
//            Console.WriteLine($"나눗셈의 나머지{num1 % num2}");
//        }
//        static void Main(string[] args)
//        {
//            int count = 0;
//            while (true)
//            {
//                Console.WriteLine("두개의 숫자 입력:\n");
//                Console.WriteLine("첫번째 숫자 입력:\n");
//                int num1 = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("두번쨰 숫자 입력:\n");
//                int num2 = Convert.ToInt32(Console.ReadLine());
                

//                try // 예외 발생 할 만한 지역으로 try를 넣음
//                {
//                    Divide(num1, num2);
//                    Console.WriteLine("나눗셈을 마쳤습니다.");
//                }
//                catch (Exception expn)// 예외가 발생하면 예외처리 내용을 받는 곳
//                {
//                    Console.WriteLine($"{expn.Message}");
//                    Console.WriteLine($"프로그램을 다시 실행하세요{++count}");

//                }
//                finally // 예외가 발생하거나 하지않을거나 해도 무조건 거쳐가는 공간
//                {
//                    Console.WriteLine("프로그램 종료");
//                }
//                if (num2 != 0) 
//                    break;
//                if (count == 3)
//                {
//                    Console.WriteLine($"세번 이상 0으로 입력함");
//                    break;
//                }
//            }
            
               
              
//        }
//    }
//}
