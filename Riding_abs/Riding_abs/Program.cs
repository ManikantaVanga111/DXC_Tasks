namespace Riding_abs
{

    abstract class Class1
    {
        public abstract void add();
        
    }

    class Class2 : Class1
    {
        public override void add()
        {
            Console.WriteLine("hi");
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Class1 C= new Class2(); 
            C.add();
        }
    }
}