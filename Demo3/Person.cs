using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Person
    {
        private string iD;
        private string fullName;

        public Person()
        {

        }

        public Person(string iD, string fullName)
        {
            this.iD = iD;
            this.fullName = fullName;
        }

        public string ID { get => iD; set => iD = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public void Input()
        {
            Console.Write("Nhap Ma So: ");
            ID = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            FullName = Console.ReadLine();

        }
        public void Output()
        {
            Console.Write("Ma So: {0} | Ho Ten: {1} | ", ID, FullName);
        }

    }
}
