using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Program
    {
        static void themSinhVien(List<Student> students)
        {
            Console.WriteLine("Nhap Thong tin sinh vien can them");
            Student student = new Student();
            student.Input();
            students.Add(student);
            Console.WriteLine("Them Thanh Cong");
        }
        static void themGiaoVien(List<Teacher> teachers)
        {
            Console.WriteLine("Nhap Thong tin giao vien can them");
            Teacher teacher = new Teacher();
            teacher.Input();
            teachers.Add(teacher);
            Console.WriteLine("Them Thanh Cong");
        }
        static void xuatDSSinhVien(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh Sach Sinh Vien Rong");
                return;
            }
            Console.WriteLine("------------- Danh Sach Thong Tin Chi Tiet Sinh Vien -------------");
            students.ForEach(student =>
            {
                student.Output();
            });
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
        static void xuatDSGiaoVien(List<Teacher> teachers)
        {
            if (teachers.Count == 0)
            {
                Console.WriteLine("Danh Sach Giao Vien Rong");
                return;
            }
            Console.WriteLine("------------- Danh Sach Thong Tin Chi Tiet Giao Vien -------------");
            teachers.ForEach(teacher =>
            {
                teacher.Output();
            });
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
        static void xuatSinhVienCNTT(List<Student> students)
        {
            Console.WriteLine("------------- Danh Sach Thong Tin Chi Tiet Sinh Vien Thuoc Khoa CNT -------------");
            students.ForEach(student =>
            {
                if (student.Faculty == "CNTT") student.Output();
            });
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
        static void xuatSVCoDTBCaoNhatVaThuocKhoaCNTT(List<Student> students)
        {
            Console.WriteLine("------------- Danh Sach Thong Tin Chi Tiet Sinh Vien Co DTB Cao Nhat Va Thuoc Khoa CNTT -------------");
            float maxDiem = students.Max(student => student.AverageScore);
            students.ForEach(student =>
            {
                if (student.AverageScore == maxDiem && student.Faculty == "CNTT") student.Output();
            });
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
        static void xuatSoLuongXepLoai(List<Student> students)
        {
            Console.WriteLine("------------- So Luong cua tung xep loai trong danh sach sinh vien -------------");
            int cntXuatSac = students.Count(student => student.AverageScore > 9);
            int cntGioi = students.Count(student => student.AverageScore <= 9 && student.AverageScore > 8);
            int cntKha = students.Count(student => student.AverageScore <= 8 && student.AverageScore > 7);
            int cntTrungBinh = students.Count(student => student.AverageScore <= 7 && student.AverageScore > 5);
            int cntYeu = students.Count(student => student.AverageScore <= 5 && student.AverageScore > 4);
            int cntKem = students.Count(student => student.AverageScore <= 4);
            Console.WriteLine("Xuat Sac: {0}", cntXuatSac);
            Console.WriteLine("Gioi: {0}", cntGioi);
            Console.WriteLine("Kha: {0}", cntKha);
            Console.WriteLine("Trung Binh: {0}", cntTrungBinh);
            Console.WriteLine("Yeu: {0}", cntYeu);
            Console.WriteLine("Kem: {0}", cntKem);
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
        static void xuatDSGiaoVienQuan9(List<Teacher> teachers)
        {
            Console.WriteLine("------------- Danh sach giao vien co thong tin o quan 9 -------------");
            teachers.ForEach(teacher =>
            {
                if (teacher.DiaChi.Contains("Quan 9")) teacher.Output();
            });
            Console.WriteLine("---------------------------------------------------------------------");
        }
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("================== Menu =====================");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Them Giao Vien");
                Console.WriteLine("3. Xuat Danh Sach Sinh Vien");
                Console.WriteLine("4. Xuat Danh Sach Giao Vien");
                Console.WriteLine("5. So Luong Tung Danh Sach (Tong so sinh vien , giao vien)");
                Console.WriteLine("6. Xuat Danh Sach Sinh Vien Thuoc Khoa CNTT");
                Console.WriteLine("7. Xuat Ra Danh Sach Giao Vien Co Dia Chi Chu Thong Tin Quan 9");
                Console.WriteLine("8. Xuat ra danh sach sinh vien co diem trung binh cao nhat va thuoc khoa CNTT");
                Console.WriteLine("9. So Luong cua tung xep loai trong danh sach sinh vien");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Chon chuc nang (0-9):");
                Console.WriteLine("==============================================");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        themSinhVien(studentList);
                        break;
                    case "2":
                        themGiaoVien(teacherList);
                        break;
                    case "3":
                        xuatDSSinhVien(studentList);
                        break;
                    case "4":
                        xuatDSGiaoVien(teacherList);
                        break;
                    case "5":
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("Tong So Sinh Vien: {0}", studentList.Count);
                        Console.WriteLine("Tong So Giao Vien: {0}", teacherList.Count);
                        Console.WriteLine("-------------------------------------------------");
                        break;
                    case "6":
                        xuatSinhVienCNTT(studentList);
                        break;
                    case "7":
                        xuatDSGiaoVienQuan9(teacherList);
                        break;
                    case "8":
                        xuatSVCoDTBCaoNhatVaThuocKhoaCNTT(studentList);
                        break;
                    case "9":
                        xuatSoLuongXepLoai(studentList);
                        break;
                    default:
                        {
                            Console.WriteLine("Khong co lua chon nay , vui long nhap lai");
                            break;
                        }
                }
            }
        }
    }
}
