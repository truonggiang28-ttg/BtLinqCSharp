using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiTap
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Khoa { get; set; }
        public double Gpa { get; set; }
        public int svNam { get; set; }
    }

    public class BtTrenLop
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Thai Truong Giang_2415053122313_225LTC#02");
            Console.WriteLine("----------------------------------------\n");

            List<Student> students = new List<Student>();
            Random rnd = new Random();
            string[] danhSachKhoa = { "Cong nghe so", "Dien", "Co khi", "Hoa sinh", "Xay dung" };

            for (int i = 1; i <= 15; i++)
            {
                students.Add(new Student
                {
                    Id = i,
                    Name = "SV_" + i,
                    Age = rnd.Next(18, 25),
                    Khoa = danhSachKhoa[rnd.Next(danhSachKhoa.Length)],
                    Gpa = Math.Round(rnd.NextDouble() * 4, 2),
                    svNam = rnd.Next(1, 5)
                });
            }
            Console.WriteLine("Danh sach sinh vien la: ");
            foreach(var i in students)
            {
                Console.WriteLine($"Id = {i.Id}| Name = {i.Name}| Tuoi = {i.Age}| Khoa = {i.Khoa}| Gpa = {i.Gpa}| Sinh vien nam: {i.svNam}");
            }

            //1.Max tuoi, min tuoi
            var tuoiMax = students.Max(s => s.Age);
            var tuoiMin = students.Min(s => s.Age);
            Console.WriteLine("\n1.----------------------------------------\n");
            Console.WriteLine($"Tuoi max = {tuoiMax} | Tuoi min = {tuoiMin}");

            //2. kiem tra co sinh vien thuoc khoa cns 
            var ktKhoa = students.Any(s => s.Khoa == "Cong nghe so");
            Console.WriteLine("\n2.----------------------------------------");
            if (ktKhoa)
            {
                Console.WriteLine("Co sinh vien thuoc khoa cong nghe so");
            }
            else
            {
                Console.WriteLine("Khong co sinh vien thuoc khoa cong nghe so");
            }

            //3.lay 10 sinh vien co diem tb cao nhat khoa

            var listResult = students.OrderByDescending(s => s.Gpa).Take(10);
            Console.WriteLine("\n3.----------------------------------------");
            Console.WriteLine("Danh sach sinh vien co diem tb cao nhat la");
            foreach (var i in listResult)
            {
                Console.WriteLine($"Id = {i.Id}| Name = {i.Name}| Tuoi = {i.Age}| Khoa = {i.Khoa}| Gpa = {i.Gpa}| Sinh vien nam: {i.svNam}");
            }

            //4. bo qua sinh vien nam cuoi, lay danh sach sinh vien con lai in ra

            var dsResult = students.Where(s => s.svNam < 4);
            Console.WriteLine("\n4.----------------------------------------");
            Console.WriteLine("Danh sach sinh vien tu nam 1 den 3 la: ");
            foreach (var i in dsResult)
            {
                Console.WriteLine($"Id = {i.Id}| Name = {i.Name}| Tuoi = {i.Age}| Khoa = {i.Khoa}| Gpa = {i.Gpa}| Sinh vien nam: {i.svNam}");
            }
            Console.ReadKey();
        }
    }
}