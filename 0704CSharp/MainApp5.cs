//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0704CSharp
//{
//    internal class MainApp5
//    {
//        static int Divide(int divdend, int divisor)
//        {
//            try
//            {
//                Console.WriteLine("Divide 시작");
//                return divdend/divisor;
//                // 예외가 일어나지 않고 정상적으로 return 하더라도 finally는 실행한다.
//            }
//            catch(DataMisalignedException e)
//            {
//                Console.WriteLine("Dicide()예외발생");
//                throw e; // 예외가 일어나더라도 finally 절은 실행된다.
//            }
//            finally
//            {
//                Console.WriteLine("Divide () 끝");
//            }

//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.Write("제수를 입력하세요");
//                string temp = Console.ReadLine();
//                int divisor = Convert.ToInt32(temp);
//                Console.WriteLine("피 제수를 입력 하세요");
//                temp = Console.ReadLine();
//                int divdend = Convert.ToInt32(temp);
//                Console.WriteLine("{0} / {1}={2} ",divdend,divisor,Divide(divdend,divisor));
//            }
//            catch (FormatException e) //양식에 관련된 예외처리 객체
//            {
//                Console.WriteLine("에러: " +e.Message);
//            }
//            catch(DivideByZeroException e)
//            {
//                Console.WriteLine("에러:"+ e.Message);
//            }
//            finally
//            {
//                Console.WriteLine("프로그램을 종료");
//            }
//        }
//    }
//}
