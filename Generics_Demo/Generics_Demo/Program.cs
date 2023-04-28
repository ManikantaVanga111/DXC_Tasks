using System.Security.Cryptography.X509Certificates;

namespace Generics_Demo
{
    class Generic<t>
    {
        public void add(t x,t y) {
      

            Console.Write($"{x} {y} ");// we pass data types 
        }
    }
    class Class1<t,u>
    {
        public void sub(t x,u y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    class Class2<i>
    {
        i num;
        public void supply(i x)
        {
            num = x;
        }
        public i re()
        {
            return num;
        }
    }
    class Class3
    {
        int num=1;
        public void supply1(int x)
        {
            num+=10;
        }
        public void supply2() {
            Console.WriteLine(num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello, World!");

            Generic<int> sc= new Generic<int>();
            sc.add(1,2);
            Class1<int,string> s1 = new Class1<int,string>();
            s1.sub(3,"Hi welcome");
            Class2<int> s2 = new Class2<int>();
           s2.supply(10);
            Console.WriteLine(s2.re());
            Class3 s3 = new Class3();
            s3.supply2();
        }
    }
}