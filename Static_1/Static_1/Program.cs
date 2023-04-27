namespace Static_1
{

    class Demo
      {
        static int n = 0;
         public void show1()
        {
            Console.WriteLine(n++);
        }
     /*   public void show2()
        {
            Console.WriteLine(n++);
        }
        public void show3()
        {
            Console.WriteLine(n++);
        }*/

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Demo sc = new Demo();
            Demo sc1 = new Demo();
            Demo sc2 = new Demo();
            sc.show1();
            sc1.show1(); ;
            sc2.show1(); ;  
          //  sc1.show2();
          //  sc2.show3();
        }
    }
}