using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "An", Age = 14 },
                new Student { Id = 2, Name = "Binh", Age = 15 },
                new Student { Id = 3, Name = "Anh", Age = 18 },
                new Student { Id = 4, Name = "Cuong", Age = 17 },
                new Student { Id = 5, Name = "Dung", Age = 19 }
            };

            Console.WriteLine("=== Danh sach toan bo hoc sinh ===");
            foreach (var s in students) s.Show();

   
            Console.WriteLine("\n=== Hoc sinh co tuoi tu 15 den 18 ===");
            var tuoi15_18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var s in tuoi15_18) s.Show();

  
            Console.WriteLine("\n=== Hoc sinh co ten bat dau bang 'A' ===");
            var batDauA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var s in batDauA) s.Show();

        
            Console.WriteLine("\nTong tuoi cua tat ca hoc sinh: " + students.Sum(s => s.Age));

        
            Console.WriteLine("\n=== Hoc sinh co tuoi lon nhat ===");
            int maxAge = students.Max(s => s.Age);
            var lonNhat = students.Where(s => s.Age == maxAge);
            foreach (var s in lonNhat) s.Show();

      
            Console.WriteLine("\n=== Danh sach sap xep theo tuoi tang dan ===");
            var sapXep = students.OrderBy(s => s.Age);
            foreach (var s in sapXep) s.Show();
        }
    }
}
