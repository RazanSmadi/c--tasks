using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._21
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("task 1:");
            Console.WriteLine("\n");
            Console.WriteLine("inter first number:");
            string num1 = Console.ReadLine();
            int number1 = Convert.ToInt32(num1);
            Console.WriteLine("inter second number:");
            string num2 = Console.ReadLine();
            int number2 = Convert.ToInt32(num2);
            if(number1>number2)
            {Console.WriteLine(number2 + " :is the smaller");}



            Console.WriteLine("task 2:");
            Console.WriteLine("\n");
            string num = Console.ReadLine();
            char sign = num[0];
            if (sign == '-') { Console.WriteLine("The sign is: -" ); }
            else { Console.WriteLine("The sign is: +"); }



            Console.WriteLine("task 3:");
            Console.WriteLine("\n");

            int[] array = {0,-1,4 };
            if (array[0] > array[1] && array[0] > array[2] )
            {

                if (array[1] > array[2])
                    Console.WriteLine(array[0] +" "+array[1] + " "+ array[2]);
                else { Console.WriteLine(array[0] + " " + array[2] + " " + array[1]); }
            }
            if (array[1] > array[0] && array[1] > array[2])
            {

                if (array[0] > array[2])
                    Console.WriteLine(array[1] + " "+ array[0] + " "+ array[2]);
                else { Console.WriteLine(array[1] + " "+ array[2] + " "+ array[0]); }
            }
            if (array[2] > array[1] && array[2] > array[0])
            {

                if (array[1] > array[0])
                    Console.WriteLine(array[2] + " "+ array[1] + " "+ array[0]);
                else { Console.WriteLine(array[2] + " "+ array[0] + " "+ array[1]); }
            }

            Console.WriteLine("task 4:");
            Console.WriteLine("\n");

            int[] array1 = { -5, -2, -6, 0, -1 };
            int max = array1[0];
            for(int i = 1; i < array1.Length; i++)
            {
                if (max < array1[i]) { max = array1[i];}
            }
            Console.WriteLine(max);


            Console.WriteLine("task 5:");
            Console.WriteLine("\n");

            double kilo = 15.0;
            double miles = kilo / 1.60934;

            Console.WriteLine(miles + ":miles per hour");


            Console.WriteLine("task 6:");
            Console.WriteLine("\n");

            int hours = Convert.ToInt32(Console.ReadLine());

            int minutes = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("The total:"+(hours * 60+ minutes ));


            Console.WriteLine("task 7:");
            Console.WriteLine("\n");

            int m = Convert.ToInt32(Console.ReadLine());
            int h = m / 60;
            int mm = m % 60;

            Console.WriteLine(h+ " Hours," + mm + "Minutes");


            Console.WriteLine("task 8:");
            Console.WriteLine("\n");
            string[] name = { "Razan", "ali", "Amer", "haya", "momen", "Yazeed" };
            Console.WriteLine(name[0].Substring(0, 3));
            Console.WriteLine(name[1].Substring(0, 3));
            Console.WriteLine(name[2].Substring(0, 3));
            Console.WriteLine(name[3].Substring(0, 3));
            Console.WriteLine(name[4].Substring(0, 3));
            Console.WriteLine(name[5].Substring(0, 3));

        }
    }
}
        