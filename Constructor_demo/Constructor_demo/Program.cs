namespace Constructor_demo
{

    class Demo
    {
        public Demo() {
            Console.WriteLine("This is constructor");

        }
       public void show()
       {
          Console.WriteLine("This is method");
       }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Demo sc=new Demo();
           sc.show();
        }
    }
}