using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _28._11
{
    public class car
    {
        public int year { set; get; }
        public string type { set; get; }
        public string model { set; get; }
        public int Pno { set; get; }
        public string color { set; get; }

        public car(int year, string type, string model, int Pno, string color)
        {

            this.year = year;
            this.type = type;
            this.model = model;
            this.Pno = Pno;
            this.color = color;
        }

        public void startengine()
        {
            Console.WriteLine("start engine");
        }
        public void endengine()
        {
            Console.WriteLine("end engine");
        }
        public void test()
        {
            Console.WriteLine($" year:  {year} , type: {type} , model: {model} , Pallet No:  {Pno}, color:  {color}");
        }

    }
    class bmw : car
    {

        public String DRIVER { set; get; }
        public bmw(string driver, int year, string type, string model, int Pno, string color) : base(year, type, model, Pno, color)
        {
            DRIVER = driver;

        }

        public int howmuch(int l) { return 20 * l; }
    }
    class test
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                car car1 = new car(1999, "bmw", "wu2", 21212, "blue");
                car1.startengine();
                car1.test();
                car1.endengine();
                bmw obj1 = new bmw("razan", 1999, "bmw", "wu2", 21212, "blue");
                string S = obj1.DRIVER;
                Console.WriteLine(S);
                int x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine( obj1.howmuch(x));
            }
        }

    }
}