using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiTap
{
    public class Bt4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313_225LTC#02");
            Console.WriteLine("----------------------------------------\n");
            List<int> list = new List<int>();
            Console.WriteLine("Nhap so luong phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu thu {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
            }
            var listResult = from num in list
                             orderby num descending
                             select num;

            Console.WriteLine("\n----------------------------------------\n");
            Console.Write("Day so nguyen sau khi sap xep giam dan: ");
            foreach (int j in listResult)
            {
                Console.Write($"{j} ");
            }
            Console.ReadKey();
        }
    }
}