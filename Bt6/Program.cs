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
            
            var listResult = from i in list
                             where i % 2 == 0
                             select i * i;
            int dem = 0;
            Console.WriteLine("\n----------------------------------------\n");
            Console.Write("So luong so chan co trong day la: ");
            foreach (int i in listResult)
            {
                dem++;
            }
            Console.Write($"{dem} ");
            Console.ReadKey();
        }
    }
}