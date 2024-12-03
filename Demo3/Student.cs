using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Student : Person
    {
        private float averageScore;
        private string faculty;
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        public Student() { }
        public Student(string iD, string fullName, float averageScore, string faculty) : base(iD, fullName)
        {
            AverageScore = averageScore;
            Faculty = faculty;
        }
        public void Input()
        {

            base.Input();
            Console.Write("Nhap Diem Trung Binh: ");
            float avg;
            bool ok = false;
            do
            {
                ok = float.TryParse(Console.ReadLine(), out avg);
                if (!ok)
                {
                    Console.WriteLine("Nhap sai kieu du lieu , vui long nhap lai");
                    continue;
                }
                else
                {
                    averageScore = avg;
                }
                if (averageScore < 0 || averageScore > 10)
                {
                    ok = false;
                    Console.WriteLine("Vui long nhap diem DTB (0-10)");
                }
                else
                {
                    ok = true;
                }
            } while (!ok || averageScore < 0 || averageScore > 10);
            Console.Write("Nhap Khoa: ");
            Faculty = Console.ReadLine();

        }
        public void Output()
        {
            base.Output();
            Console.WriteLine("Khoa: {0} | DiemTB: {1}", faculty, averageScore);
        }
    }
}
