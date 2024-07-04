//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0704CSharp
//{
//    internal class Mainapp3
//    {

//        static void DoSomeThing(int arg)
//        {
//            if (arg < 10)
//            {
//                Console.WriteLine($"{arg}");
//            }
//            else
//            {
//                throw new Exception("arg가 10보다 크데요");
//            }
//        }
//        static void Main(string[] args)
//        {
//            int Count = 0;
//            int arg = 0;
//            while (true)
//            {
//                Console.WriteLine("숫자를 기입하세요");
//                arg = Convert.ToInt32(Console.ReadLine());
//                try
//                {


//                    DoSomeThing(arg);


//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                    Console.WriteLine($"프로그램을 다시 실행하세요{++Count}");
//                }
//                finally
//                {
//                    Console.WriteLine("프로그램 종료");
//                }
//                if (arg != 0)
//                    break;
//                if (Count == 3)
//                {
//                    Console.WriteLine($"세번이상입력");
//                    break;
//                }


//            }



//        }
//    }
//}
