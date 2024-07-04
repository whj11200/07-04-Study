//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0704CSharp
//{
//    internal class MainAPP2
//    {
//        static void Dievide(int n1, int n2)
//        {
//            if (n2 == 0)
//                throw new DataMisalignedException("0으로 나누어질수없다.");


//            Console.WriteLine("나눗셈 몫{0}", n1 / n2);
//            Console.WriteLine("나눗셈 몫 나머지{0}", n1 % n2);
//        }
//        static void Main(string[] args)
//        {
//            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            try
//            {

//                for (int i = 0; i < 11; i++)
//                {
//                    Console.WriteLine(arr[i]);
//                }
//                Dievide(n1, n2);
//                Console.WriteLine("나눗셈마침");
//            }
//            catch (IndexOutOfRangeException e)
//            {
//                Console.WriteLine($"예외가 발생해버렸수다.{e.Message}");
//            }
//            catch (DivideByZeroException e)
//            {
//                Console.WriteLine($"예외 발생함요:{e.Message}");
//            }
//            Console.WriteLine("종료");
//        }
//    }
//}
