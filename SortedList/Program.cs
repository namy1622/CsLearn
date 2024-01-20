using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
   
        

        static void Main(string[] args)
        {
            /*
                    //-- TestSortedList--
                TestSortedList.test();
             */

            //-- Queue_Stack -- 
            Console.WriteLine("\n * Queue *\n");
            Queue_Stack.testQueue();

            Console.WriteLine("\n * Stack *\n");
            Queue_Stack.testStack();


            Console.WriteLine("\n\n ------------------");
            Console.WriteLine($"--- LinkedLlist - Danh sach kien ket ---");
            LinkLedist.test();


            Console.WriteLine("\n\n ------------------");
            Console.WriteLine($"--- Dictionary ---");
            Dictionary_Hash.testDic();

            Console.WriteLine("\n\n ------------------");
            Console.WriteLine($"--- Hash ---");
            Dictionary_Hash.testHash();
        }
    

        
    }
}
