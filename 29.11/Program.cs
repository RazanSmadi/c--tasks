using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _29_11
{
    class Employee
    {
        public string name { get; set; }
        public int id { get; set; }
        public DateTime dateofbirth { get; set; }
        public Employee(string name, int id, int day, int month, int year)
        {
            this.name = name;
            this.id = id;
            dateofbirth = new DateTime(year, month, day);

        }

        public void age()
        {
            DateTime now = DateTime.Now; TimeSpan value = now.Subtract(dateofbirth);

            Console.WriteLine((int)value.TotalDays / 365);

        }
        public virtual void print() { Console.WriteLine(name + " " + id + " " + dateofbirth); }

    }
    class Manager : Employee
    {
        public Manager(string name, int id, int day, int month, int year) : base(name, id, day, month, year)
        {
        }
        public override void print()
        {
            Console.WriteLine(name + " " + id + " ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Manager manger = new Manager("razan", 99, 3, 11, 1999);
            manger.print();
            manger.age();
        }
    }
}
