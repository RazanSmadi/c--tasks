using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._11
{

    public class Employee
    {
        public string name { set; get; }
        public int birth { set; get; }
        public int ID { set; get; }
        public  Employee(string name,  int birth, int ID)
        {

            this.name = name;
            this.birth = birth;
            this.ID = ID;
        }

        public virtual void calcAge(int year)
        {

        }
        public void test()
        {
            Console.WriteLine($" Name:  {name} , BIRTH DAY: {birth} , ID: {ID}");
        }

    }
    class Manger: Employee
    {

        
        public Manger(string name, int birth,int id ) : base(name,birth,id)
        {
            

        }
        public override void calcAge(int year)
        {
           Console.WriteLine(  2022 - year);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manger m = new Manger("razan", 1999 , 999);
            m.test();
            m.calcAge(1999);

        }
    }
}
