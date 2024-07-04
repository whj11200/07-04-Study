//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0704CSharp
//{
//    internal class Mainapp4
//    {
//       static void Main(string[] args)
//        {
//            try
//            {
//                int? a = null;
//                // a는 null 이므로 b를 할당하지 않고 바로 throw 로 넘어간다
//                int b = a ?? throw new ArgumentNullException();
//            }
//            catch(ArgumentNullException e)
//            {
//                Console.WriteLine(e);
//            }
//            try
//            {
//                int[] array = new[] { 1, 2, 3 };
//                int index = 4;
//                int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
//            }
//            catch (IndexOutOfRangeException e)
//            {
//                Console.WriteLine(e);
//            }
//        }
       
//    }
//}
