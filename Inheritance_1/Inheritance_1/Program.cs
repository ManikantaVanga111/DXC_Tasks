namespace Inheritance_1
{
    class Calculator{
        public Calculator()
        {
            Console.WriteLine("hi constructor");
        }

    }
    class Cal1 : Calculator
    {
        public Cal1()
        {
            Console.WriteLine("hi second  constructor");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Calculator sc=new Calculator();
          Cal1 sc= new Cal1();  
        }
    }
}