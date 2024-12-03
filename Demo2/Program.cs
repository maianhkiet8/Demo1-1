using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
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
        static void xuatDanhsachSinhVien(List<Student> students)
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
        static void xuatSinhVienCNTT(List<Student> students)
        {
            Console.WriteLine("------------- Danh Sach Thong Tin Chi Tiet Sinh Vien Thuoc Khoa CNT -------------");
            students.ForEach(student =>
            {
                if (student.Faculty == "CNTT") student.Output();
            });
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
        static void xuatSinhVienDBTLonHon5(List<Student> students)
        {
            Console.WriteLine("------------- Danh Sach Thong Tin Chi Tiet Sinh Vien Co DTB >= 5 -------------");
            students.ForEach(student =>
            {
                if (student.AverageScore >= 5) student.Output();
            });
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
        static void xuatSinhVienDTBTangDan(List<Student> students)
        {
            Console.WriteLine("------------- Danh Sach Thong Tin Chi Tiet Sinh Vien Co DTB Tang Dan -------------");
            students.OrderBy(s => s.AverageScore).ToList().ForEach(student =>
            {
                student.Output();
            });
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
        static void xuatSVKhoaCNTTVaDTBLonHon5(List<Student> students)
        {
            Console.WriteLine("------------- Danh Sach Thong Tin Chi Tiet Sinh Vien Thuoc Khoa CNTT Va DTB >=5 -------------");
            students.ForEach(student =>
            {
                if (student.Faculty == "CNTT" && student.AverageScore >= 5) student.Output();
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
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("================== Menu =====================");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Thong tin sinh vien thuoc khoa CNTT");
                Console.WriteLine("4. Thong tin sinh vien co DTB >= 5");
                Console.WriteLine("5. Danh sach sinh vien sap xep theo diem TB tang dan");
                Console.WriteLine("6. Danh sach sinh vien co diem TB >= 5 va thuoc khoa CNTT");
                Console.WriteLine("7. Xuat ra danh sach sinh vien co diem trung binh cao nhat va thuoc khoa CNTT");
                Console.WriteLine("8. So Luong cua tung xep loai trong danh sach sinh vien");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Chon chuc nang (0-8):");
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
                        xuatDanhsachSinhVien(studentList);
                        break;
                    case "3":
                        xuatSinhVienCNTT(studentList);
                        break;
                    case "4":
                        xuatSinhVienDBTLonHon5(studentList);
                        break;
                    case "5":
                        xuatSinhVienDTBTangDan(studentList);
                        break;
                    case "6":
                        xuatSVKhoaCNTTVaDTBLonHon5(studentList);
                        break;
                    case "7":
                        xuatSVCoDTBCaoNhatVaThuocKhoaCNTT(studentList);
                        break;
                    case "8":
                        xuatSoLuongXepLoai(studentList);
                        break;
                    default:
                        {
                            Console.WriteLine("Khong co lua chon nay , vui long nhap lai");
                            break;
                        }
                }
            }
            Console.ReadLine();
        }
    }
}
