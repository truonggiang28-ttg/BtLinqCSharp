using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiTap
{
    public class Bt19
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

            Console.WriteLine("\n----------------------------------------\n");
            var listGroup = list.GroupBy(n => n);
            var countMax = listGroup.Max(num => num.Count() );
            var resultGroup = listGroup.Where(n => n.Count() == countMax);
            foreach(var i in resultGroup)
            {
                Console.WriteLine($"So xuat hien nhieu nhat la {i.Key} xuat hien {countMax} lan"); 
            }
            Console.ReadKey();
        }
    }
}
