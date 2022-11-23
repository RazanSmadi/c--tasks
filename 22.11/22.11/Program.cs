using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _22._11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task1
            int[] ARR = new int[] { 1, 7, 9,45 };
            string[] arr2 = new string[] { "Str" ,"alex", "moh" };
            string[] arr3 = new string[] { "the", "fox","over","lazy", "dog" };

            //task2 
            //What the index of "Banana","Tomato" ?
            //String[ ]  fruits =["Tomato", "Banana", "Watermelon"]
            //the index of Banana:1   , Tomato:0




//Favorite Food(5 item)
//Favorite Sport(3 item)
//Favorite Movie(4 item)

            //task3
            string[] food = new string[] { "Cheesy Pizza", "Burgers","Cheesy"," Popcorn", "Red Velvet Cake" };
            string[] sport = new string[] { "Combat Sports", "Cycle Sports ", "Gymnastics"};
            string[] movie = new string[] { "jocker", "Harry Botter","gifts"," Popcorn" };
            foreach (string f in food) { Console.WriteLine("My Favorite Food :" + f); }
            foreach (string s in sport) { Console.WriteLine("My Favorite Sport  :" + s);}
            for(int i=0;i<movie.Length;i++) { Console.WriteLine("My Favorite Movie :" + movie[i]); }


            //task4
            Console.WriteLine("Input three numbers separated by comma: ");
            string number =Console.ReadLine();
            string[] num= number.Split(',');
            Console.WriteLine(Convert.ToInt32 (num[0]) + Convert.ToInt32(num[1]) + Convert.ToInt32(num[2]));






            //task5
            int sum = 0;

            Console.Write("The odd numbers are : ");
            for (int i = 1; i < 100; i++)
            {

                if (i % 2 != 0)
                {
                    Console.Write( i + " ");
                    sum += i;
                }
            }

            Console.WriteLine("\n"+"the sum is:"+sum);
            
            //task6

            for(int i=0; i < 4; i++) {

                for (int j = 4 - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.Write("\n");
            }
            //task7
            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4- i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                   
                    counter++;
                    Console.Write(counter + " ");
                }
                Console.Write("\n");
            }



        }
    }
}
