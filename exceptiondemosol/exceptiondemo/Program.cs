using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2 :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            try
            {
                int res = num1 / num2;
                Console.WriteLine("the result is " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine("Application Completed");
            }
         
            finally
            {
                Console.WriteLine("Application Completed");
            }
            Console.ReadLine();
        }
    }
}