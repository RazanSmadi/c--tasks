using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user = Console.ReadLine();
            Console.WriteLine(user);

            double salary = 700.50;
            string name = "Razan";
            char mychar = 'R';
            bool Bool = true;
            int Num = 9;               
           const double bai = 3.14;

            Console.WriteLine("my salary is: "+salary);
            Console.WriteLine("my name is: "+name);
            Console.WriteLine("my first char: "+mychar);
            Console.WriteLine("the bool ex: "+Bool);
            Console.WriteLine("my fav number: "+Num);
            Console.WriteLine("the const ex: "+bai);


            string[] cars = { "Volvo", "BMW", "Ford"};
            for (int i=0;i<cars.Length;i++) {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("the length of this array:"+cars.Length);



            Console.WriteLine("Input your firstname: ");
            string fname = Console.ReadLine();


            Console.WriteLine("Input your lastname: ");
           string lname= Console.ReadLine();

            Console.WriteLine("Input your year of birth: ");
           string yofb= Console.ReadLine();


            Console.WriteLine(fname+" "+ lname+" " + yofb);


           int[] numbers = {1,1,2,3,4,5,6,7,8,9};
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }


            int sum = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5] + numbers[6] + numbers[7] + numbers[8] + numbers[9];
            Console.WriteLine("the sum of numbers array : "+sum);
        }
    }
}
