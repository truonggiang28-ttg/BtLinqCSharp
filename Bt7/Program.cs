using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiTap
{
    public class Bt6
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

            Console.WriteLine("----------------------------------------\n");
            var listResult = list.Any(i => i > 10);
            int dem = 0;
            if (listResult)
            {
                Console.WriteLine("Co it nhat 1 phan tu lon hon 10");
            }
            else
            {
                Console.WriteLine("Khong co phan tu nao lon hon 10");
            }
            Console.ReadKey();
        }
    }
}