using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Queue_Stack
    {
        public static void testQueue()
        {
            Queue<string> hoso_caxuly = new Queue<string>();

            hoso_caxuly.Enqueue("Hồ sơ A"); // Hồ so xếp thứ nhất 
            hoso_caxuly.Enqueue("Hồ sơ B"); // Hò sơ thứ 2
            hoso_caxuly.Enqueue("Hồ sơ C"); // hồ so xếp thứ 3


            // lấy hồ sơ xếp trước xử lý trước, cho đến hết 
            while(hoso_caxuly.Count > 0)
            {
                var hoso = hoso_caxuly.Dequeue(); //Dequeue:đọc và loại ngay phần tử đầu hàng đợi
                                                  // lỗi nếu hagnf đợi kông có phần tử nào 
                Console.WriteLine($" - Xử lý {hoso}, còn lại {hoso_caxuly.Count}");
            }
        }

        //-------------------
        public static void testStack()
        {
            Stack<int> daySo = new Stack<int>();

            daySo.Push(5);
            daySo.Push(3);
            daySo.Push(6);
            daySo.Push(8);
            daySo.Push(2);

            while (daySo.Count > 0)
            {
                var num = daySo.Pop();
                Console.WriteLine($"Lấy số {num} - còn lại {daySo.Count} số ");
            }
        }
    }
}
