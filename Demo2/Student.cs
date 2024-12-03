using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Student
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        public Student() { }
        public Student(string studentID, string fullName, float averageScore, string faculty)
        {
            this.StudentID = studentID;
            this.FullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }
        public Student(Student student)
        {
            this.StudentID = student.StudentID;
            this.FullName = student.FullName;
            this.averageScore = student.averageScore;
            this.faculty = student.faculty;

        }
        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            StudentID = Console.ReadLine();
            Console.Write("Nhap Ho ten sinh vien: ");
            FullName = Console.ReadLine();
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
            Console.WriteLine("MSSV: {0} | HoTen: {1} | Khoa: {2} | DiemTB: {3}", StudentID, FullName, faculty, averageScore);
        }
    }
}
