using System;
using System.Collections.Generic;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Xuat danh sach sinh vien");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Student s = new Student();
                        s.Input();
                        students.Add(s);
                        break;

                    case "2":
                        Console.WriteLine("\n=== Danh sach sinh vien ===");
                        foreach (var st in students)
                        {
                            st.Show();
                        }
                        break;

                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le. Thu lai!");
                        break;
                }
            }
        }
    }
}
