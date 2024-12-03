using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Teacher : Person
    {
        private string diaChi;

        public Teacher() { }
        public Teacher(string ID, string HoTen, string diaChi) : base(ID, HoTen)
        {
            this.diaChi = diaChi;
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }
        public void Input()
        {
            base.Input();
            Console.Write("Nhap Dia Chi: ");
            DiaChi = Console.ReadLine();

        }
        public void Output()
        {
            base.Output();
            Console.WriteLine("Dia Chi: {0}", DiaChi);
        }

    }
}
