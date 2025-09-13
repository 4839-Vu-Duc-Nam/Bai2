using System;

namespace Lab01_01
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public double AverageScore { get; set; }

        // Ham nhap thong tin sinh vien
        public void Input()
        {
            Console.Write("Nhap ma so: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            Name = Console.ReadLine();

            Console.Write("Nhap khoa: ");
            Faculty = Console.ReadLine();

            Console.Write("Nhap diem trung binh: ");
            AverageScore = double.Parse(Console.ReadLine());
        }

        // Ham hien thi thong tin sinh vien
        public void Show()
        {
            Console.WriteLine("Ma so: {0}, Ho ten: {1}, Khoa: {2}, Diem TB: {3}",
                Id, Name, Faculty, AverageScore);
        }
    }
}
