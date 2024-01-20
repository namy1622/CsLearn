using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dictionary không cho phép trùng key 


namespace SortedList
{
    internal class Dictionary_Hash 
    {
        public static void testDic()
        {
            //khởi tạo với 2 phần tử 
            Dictionary<string, int> sodem = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["two"] = 2,
            };
            //thêm hoặc cập nhật 
            sodem["three"] = 3;

            var keys = sodem.Keys;
            foreach(var k in keys)
            {
                var value = sodem[k];
                Console.WriteLine($"{k} = {value}");
            }
        }

        public static void testHash()
        {
            HashSet<int> hashset1 = new HashSet<int>()
            {
                5,2,3,4
            };
            Console.WriteLine($"Phần tử trong hashset {hashset1.Count}");

            foreach(var h in hashset1){
                Console.WriteLine(h + " ");
            }
            HashSet<int> hashset2 = new HashSet<int>();

            hashset2.Add(3);
            hashset2.Add(2);
            if (hashset1.IsSupersetOf(hashset2))
            {
                Console.WriteLine($"hashset1 là tập chứa hashset2");
            }
        }
    }
}


/*  
 *  --- Dictionary -------
Count	            Thuộc tính cho biết số phần tử
[key]	            Indexer truy cập đến phần tử có key
Keys	            Thuộc tính là danh sách các key
Values	            Thuộc tính lấy danh sách các giá trị
Add(key, value)	    Thêm một phần tử vào Dictionary
Remove(key)	        Xóa phần tử bằng key của nó
Clear()	            Loại bỏ tất cả các phần tử
ContainKey(key)	    Kiểm tra có phần tử nào có khóa là key
ContainValue(value)	Kiểm tra có phần tử nào có giá trị là value
   
 */