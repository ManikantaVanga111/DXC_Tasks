namespace Po_riding
{
    class Class1
    {
        public virtual void add()
        {
            Console.WriteLine("hi");
        }
    }
    class Class2 :Class1
    {
        public override void add()
        {
            Console.WriteLine("hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello, World!");
            Class2 s = new Class2(); // or Class1 s= new CLass2();
            s.add();
        }
    }
}