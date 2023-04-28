using System.Security.Cryptography;

namespace Poly_overrloading
{
    class Poly
    {
        public Poly()
        {
            Console.WriteLine("Hi all");
        }
        public Poly(int x)
        {
            Console.WriteLine(x);
        }
        public Poly(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public Poly(int x,int y, int z)
        {
            Console.WriteLine(x + y + z);
        }

        public Poly(int x,float y)
        {
            Console.WriteLine(x + y);
        }
        public Poly(float a,int b)
        {
            Console.WriteLine(a+b);
        }
    }
    class Poly1
    {
        public void add(int x, int z)
        {
            Console.WriteLine(x + z);
        }
        public void add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Poly sc = new Poly(10,20);
            Poly1 s= new Poly1();
            s.add(10,20);
            s.add(20,20,20);

        }
    }
}