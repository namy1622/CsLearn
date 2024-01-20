using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class LinkLedist
    {
       
            public static void test()
            {
                LinkedList<string> baihoc = new LinkedList<string>();

                baihoc.AddFirst("Bai hoc a"); // them dau ds
                baihoc.AddLast("Bai hoc b"); // them cuoi ds
                baihoc.AddFirst("Bai hoc c");
                baihoc.AddLast("Bai hoc d");

                //lấy phần tử đầu, sau đó duyệt đến cuoois 
                Console.WriteLine($"----- Nút từ đầu đến cuối ");
                LinkedListNode<string> node;
                
                node = baihoc.First;
                while(node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;
                }

                // Lấy phần tử cuối, sau đó duyệt về phần tưr đầu 
                Console.WriteLine($"\n Nút từ cuối lên đầu ");
                node = baihoc.Last;
                while(node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Previous;
                }
            }
        
    }
}
