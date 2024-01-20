using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class TestSortedList
    {
        public static void test()
        {
            // khởi tạo sortList
            var products = new SortedList<string, string>();
            products.Add("Iphone 6", "P-IPHONE-6"); // thêm phần tư rmowis (key, value)
            products.Add("Laptop Abc", "P-LAP");
            products["Điện thoại Z"] = "P-DienThoai";  // thêm vào phần tử bằng Indexẻr  
            products["Tai nghe zzz"] = "P-Tai";        // thêm vào phần tưr băng Indexer
                                                       // 
            // Duyệt qua các phần tử , mỗi phần tử lấy key/Value lưu trong biến 
            // kiểu KeyValuePair

            Console.WriteLine($"\n---- Danh sach san pham ---");
            Console.WriteLine($"Tên và mã:");
            foreach(KeyValuePair<string, string> p in products)
            {
                Console.WriteLine($"    {p.Key} - {p.Value}");
            }
            //kết quả: (danh sách đã xếp theo key)
            // TÊN và MÃ
            //     Điện thoại Z - P-DIENTHOAI
            //     Iphone 6 - P-IPHONE-6
            //     Laptop Abc - P-LAP
            //     Tai nghe XXX - P-TAI

            Console.WriteLine("\n---- ---------- ---");

            // đọc value ki biết key
            string productName = "Tai nghe zzz";
            Console.WriteLine($"{productName} cos mã là {products[productName]}");

            Console.WriteLine($"\n---- Cập nhập giá trị vào phần tử theo key ---");

            products[productName] = "P - Tai-Updated";

            Console.WriteLine($"---- -- Duyệt qua các giá trị -- ---");
            Console.WriteLine($"-> Danh Sachs San Pham ");
            foreach(var product_code in products.Values)
            {
                Console.WriteLine($"---{product_code}");
            }

            // duyệt qua các key tương tự products.Keys


        }
    }
}
