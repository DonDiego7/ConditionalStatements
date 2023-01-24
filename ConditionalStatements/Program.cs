/*
 Author: Diego Fernandez
 Date: 1/21/2022
 Description: This application will allow you to return a grade from typing in the corresponding percentage, and will give
 message if error in the code occurs
*/
using System; // calling System library
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Conditional_Statements_Examples_1_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter some number:");

            try
            {
                int n1 = Convert.ToInt32(Console.ReadLine());
                if (n1 >= 90)
                {
                    Console.WriteLine("A");
                }
                else if (n1 >= 80)
                {
                    Console.WriteLine("B");
                }
                else if (n1 >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (n1 >= 60)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }

            } //end try

            catch (Exception e)
            {
                Console.WriteLine("Please use a decimal data type");
            }

        }
    }
}