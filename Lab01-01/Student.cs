using System;

namespace Lab01_01
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Show()
        {
            Console.WriteLine($"Id: {Id}, Ho ten: {Name}, Tuoi: {Age}");
        }
    }
}
