using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyLibrary;

namespace CSharp
{
    class Program
    {
       // public const int bonus = 12000;
        static void Main(string[] args)
        {

            //string[] Students = { "javid", "Payal", "Prajakta", "Shital" };



            //Acept any number and print factorial of number

            Console.WriteLine("enter any number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial of " + number + " is: " + fact);




            //acept a number from user and print sum from 1 to number

            //Console.WriteLine("enter any number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //for (int i = 0; i <= number; i++)
            //{
            //    result += i;
            //}

            //Console.WriteLine("sum is:" + result);


            //foreach_break__for___continue
            //for (int i = 0; i < Students.Length; i++)
            //{
            //    if (Students[i]=="Prajakta")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(Students[i]);
            //}

            //foreach (string item in Students)
            //{
            //    Console.WriteLine(item);
            //}

            //Method, property( getter, setter)

            //data type: primitive & non-primitive_ref and val___const variable

            //Var dynamic readonly and const

            //dynamic fname = "Mansi";
            //Console.WriteLine(fname);
            //fname = 1.2;
            //Console.WriteLine(fname);

            //Greetings();

            Console.Read();


        }

        /// <summary>
        /// method for greeting. Ask users name and say hello
        /// </summary>

        //private static void Greetings()
        //{
        //    Console.WriteLine("Enter your name");
        //    string fullname = Console.ReadLine();
        //    Console.Write("Hello " + fullname);
        //    Console.WriteLine("This is javid");
        //}
    }
}
