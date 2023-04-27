using Classlib;
using System.Diagnostics.CodeAnalysis;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal sc = new Cal();

            // Console.WriteLine(sc.sum(2, 3));
            // Console.WriteLine(sc.sub(2, 3));
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine(sc.sum(a, b));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(sc.sub(a, b));
                        break;

                    }
                case 3:
                    {
                        Console.WriteLine(sc.mul(a, b));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(sc.div(a, b));
                        break;
                    }
                default:

                    {
                        Console.WriteLine("wrong choice");
                        break;
                    }
            }

            Console.ReadKey();  

        }
    }
}