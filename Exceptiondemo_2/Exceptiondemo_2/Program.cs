using System;

namespace Exceptiondemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            try
            {
                Console.WriteLine("Enter the first number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter thr second number");
                b = Convert.ToInt32(Console.ReadLine());
                if (a < b)
                {
                    throw new WrongException("the value of first one is less than the second one");
                }
                c = a / b;
            }
            catch(FormatException) 
            {
                Console.WriteLine("input must be integer");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            finally {
                Console.WriteLine("program end");
                    }

        }
    }
}