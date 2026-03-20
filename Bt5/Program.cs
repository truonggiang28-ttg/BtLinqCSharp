using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiTap
{
    public class Bt5
    {
        public static void Main()
        {
            Console.WriteLine("Thai Truong Giang_2415053122313_225LTC#02");
            Console.WriteLine("----------------------------------------\n");

            List<int> list = new List<int>();
            Console.Write("Nhap so luong phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu thu {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
            }
            var listResult = from i in list
                             select i * i;
            Console.Write("Danh sach binh phuong: ");
            foreach (var item in listResult)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}