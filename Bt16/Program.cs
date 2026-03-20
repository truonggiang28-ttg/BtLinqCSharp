using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiTap
{
    public class Bt16
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313_225LTC#02");
            Console.WriteLine("----------------------------------------\n");

            List<int> list = new List<int>();
            list.AddRange(1, 2, 2, 3, 4, 4, 5);
            Console.Write("Danh sach la: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            var listResult = list.Sum();
            Console.Write($"\n\nTong cua day la: {listResult}\n");
            Console.ReadKey();

        }
    }
}
