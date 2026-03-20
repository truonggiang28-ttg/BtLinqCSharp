using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiTap
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

    }
    public class Bt20
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313_225LTC#02");
            Console.WriteLine("----------------------------------------\n");
            List<Student> students = new List<Student>()
            {
                new Student{Id=1, Name="An", Score=8},
                new Student{Id=2, Name="Binh", Score=6},
                new Student{Id=3, Name="Chi", Score=9},
                new Student{Id=4, Name="Dung", Score=7}
            };
            Console.WriteLine("Danh sach hoc sinh la:");
            foreach (Student student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");

            }
            Console.WriteLine("----------------------------------------\n");

            var listResult = students.OrderByDescending(s => s.Score).Take(3);
            Console.WriteLine($"3 Sinh vien dau lay theo diem la: ");
            foreach (var s  in listResult)
            {
                Console.WriteLine($"Id = {s.Id}| Name = {s.Name}| Diem= {s.Score}");
            }
            Console.ReadKey();  
        }

    }
}
