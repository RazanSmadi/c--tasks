using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _27._11
{
    public class Employee
    {
        int Age;
        string Gender;
        string Name;
        string EMail;
        int ID;
        string Phone;



        public Employee(int Age, string Gender, string Name, string EMail, int ID, string Phone)
        {
            if (Age >= 18 || Age <= 60)
            {
                this.Age = Age;
            }
            else
            {

                Console.WriteLine("your age not in the range");
                Console.WriteLine("inter your age ");
                int yourage =Convert.ToInt32( Console.ReadLine());
                this.Age = yourage;
            }
            this.Gender = Gender;
            this.Name = Name;
            this.EMail = EMail;
            this.ID = ID;
            string phoNum = Phone.Substring(0, 3);
            if (phoNum == "079" || phoNum == "078" || phoNum == "077")
            {
                this.Phone = Phone;
            }
            else
            {
                Console.WriteLine("Wrong phone number ");
                Console.WriteLine("inter phone number ");
                string number=Console.ReadLine();
                Phone = number;
            }
        }
        public static void print(int Age, string Gender, string Name, string EMail, int ID, string Phone)
        {
            Console.WriteLine($" My id is {ID} , Myname is {Name} , Myage is {Age} , Mygender is {Gender}, Myemail is {EMail} , Myphone {Phone}");
        }
       
       
    



        static void Main(string[] args)
        {
            Employee emp = new Employee(23, "Female", "Razan", "razansmadi99@gmal.com", 10, "0782267702");
            Employee.print(23, "Female", "Razan", "razansmadi99@gmal.com", 10, "0772267702");
         
        }
    }

}