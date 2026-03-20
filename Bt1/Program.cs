using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiTap
{
    public class Bt1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313_225LTC#02");
            Console.WriteLine("----------------------------------------\n");
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8});

            Console.Write("Danh sach da nhap la: ");
            foreach(int i in list)
            {
                Console.Write(i +" ");
            }

            var listResult = from i in list
                             where i % 2 == 0
                             select i;
            Console.WriteLine("\n----------------------------------------");
            Console.Write("\nCac so chan co trong list la: ");
            foreach(int i in listResult)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();  
        }
    }
}