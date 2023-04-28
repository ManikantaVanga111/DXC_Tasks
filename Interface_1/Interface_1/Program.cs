using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Interface_1
{
    interface Myfirst
    {
        public void add(int x,int y);
        public void sub(int x,int y);
    }
    interface Second //or Second : Myfirst
    {
        public void mul(int x,int y);
    }
    class Class2
    {
        public void per(int x,int y)
        {
            Console.WriteLine(x%y);
        }
    }
    class Class1 :Class2, Second,Myfirst
    {
        public void add(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public void sub(int x,int y)
        {
            Console.WriteLine(x-y);
        }
        public void mul (int x,int y)
        {
            Console.WriteLine(x*y);
        }
       public int div(int x,int y)
        {
            return x / y;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Class1 sc = new Class1();
            sc.add(1,2);
            int t = sc.div(4, 2);
           Console.WriteLine(t);
            sc.per(4, 2);
        }
    }
}