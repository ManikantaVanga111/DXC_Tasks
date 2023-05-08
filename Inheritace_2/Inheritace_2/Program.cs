namespace Inheritace_2
{
    class Cal1
    {
        
       // public Cal1(int x) { 
           // Console.WriteLine(10);
           // }
           public Cal1()
           {
            Console.WriteLine("hi");
           }
        public Cal1(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public Cal1(int x)
        {
            Console.WriteLine(x);
        }
        public void show(int x, int y,int z)
        {
            Console.WriteLine(x+y+z);
        }
    }

    class Cal2 : Cal1
    {
       public Cal2 () : base(9, 1)
        {
            base.show(10,20,30);    
            Console.WriteLine("Second one");
        }
        public Cal2(String x) 
        {
            Console.WriteLine(x);
        }
    }
    class Cal3 :Cal2 
    {
        public Cal3()
        {
            Console.WriteLine("nothing");
        }
      public Cal3(int x, int y) :base("hi")
       {
         Console.WriteLine(x + y);
       }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
          // Cal1 sc= new Cal1(10); 
         // Cal2 sc= new Cal2();

            Cal3 sc=new Cal3(1,4);
        }
    }
}