using System;

namespace Simple_interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P = 23000;
            float R = 12.75f;
            Console.WriteLine("Enter Year");
            int T=Convert.ToInt32(Console.ReadLine());
            float SI = (P * T * R) / 100;
            Console.WriteLine(SI);
        }
    }
}