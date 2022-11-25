using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._23
{
    internal class Program
    {
        static void task1() {
            int[] num = new int[10];
            Console.WriteLine(" Input the 10 numbers: ");
            for (int i=0;i<num.Length;i++)
            {
                num[i]= (Convert.ToInt32(Console.ReadLine()));
            }

            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i]; 

            }

            Console.WriteLine("The sum of 10 no is :" + sum);
            double avg = Convert.ToDouble(sum)/ num.Length;
            Console.WriteLine("The Average is  :" + avg);

        }


        static int task2(int x)
        { return x * x * x;  }
        
        static void task3(int[]x) 
        {
           
            int c = 0;
            for(int i=0;i<x.Length;i++)
            {
                if (x[i] > 1950)
                {
                    Console.WriteLine(x[i]);
                    c++;
                }
            }
       
        }

        static int task4( int AgeInYear) {

            return AgeInYear * 365;
        }
        static int task5(int x,int y,int z)
        {
            return x*2+y*4+z*2;
        }
        static void task6(string username, string password)
        {
            string[] usernames = { "razan", "ali", "smadi" };
            string[] passwords = { "1234", "567", "8910" };
            for (int i = 0; i < 3; i++)
            {
                if (username == usernames[i] && password == passwords[i])
                {
                    Console.WriteLine("success login. ");
                    break;
                   
                }
                else if (i == passwords.Length - 1)
                {
                    Console.WriteLine("faild login");

                }
            }

        }


        static int task7(int x, int y)
        {


            int save = x;
            if (y == 0) return 1;
            else if (y == 1) return save;
            else
            {
                for (int i = 1; i < y; i++) { x = x * save; }
                return x;
            }

        }


        static void task8(int year)
        {
            if (year <= 2024 && year >= 1900)
            {
                if (year ==1900) { Console.WriteLine(" is a not leap year."); }
                else if (year % 4 == 0){  Console.WriteLine( " is a leap year.");}
                else{Console.WriteLine(" is a not leap year.");}
            }
            else { Console.WriteLine("wrong year"); }
                
        }
        
        static void task9(int x)
        {
            bool flag = false;
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false) { Console.WriteLine(" prime"); }
            else { Console.WriteLine("not prime"); }

        }
        static int task10(string str)
        {
            int c= 0;
            string[] slicer = str.Split(' ');
                foreach (string s in slicer)
                    c++;

                return c;
            
        }

        static void Main(string[] args)
        {


            //Console.WriteLine("task1");
            //task1();
            //Console.WriteLine("\n");


            //Console.WriteLine("task2");
            //Console.WriteLine("Input number of terms "); 
            //int x = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Number is : " +x+ " and cube of the "+x+ " is "+ task2(x));
            //Console.WriteLine("\n");

            //Console.WriteLine("task3:");
            //Console.WriteLine("Write a program in C# return only numbers in the years array greater than 1950.");
            //int [] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            //task3(years);
            //Console.WriteLine("\n");


            //Console.WriteLine("task4:");
            //Console.WriteLine("inter age in year:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine( task4(age));
            //Console.WriteLine("\n");
            //Console.WriteLine("task5 : " +task5(2,3,5));
            //Console.WriteLine("\n");


            //Console.WriteLine("task6");
            //int p = Convert.ToInt32(Console.ReadLine());
            //int pp = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(p + "power of " + pp + " is " + task7(p, pp));
            //Console.WriteLine("\n");


            //Console.WriteLine("task7");
            //task6("ali", "567");
            //Console.WriteLine("\n");

            Console.WriteLine("task8");
            task8(2022);
            Console.WriteLine("\n");

            //Console.WriteLine("task9");
            //Console.WriteLine("inter number to check if prime or not");
            //int check = Convert.ToInt32(Console.ReadLine());
            //task9(check);
            //Console.WriteLine("\n");

            //Console.WriteLine("task10");
            //Console.WriteLine(task10("RAZAN ALI AHMAD AL-SMADI"));
        }
    }
}
