using System.Collections;
namespace Non_genericqueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue s=new Queue();    
            s.Enqueue(1);
            s.Enqueue(2);
            s.Enqueue(3);
            s.Enqueue(40);
   
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"dequeue element is {s.Dequeue()}");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(s.Contains(2));
            Console.WriteLine(s.Peek());
           // foreach (var item in s)
          //  if (item.Equals( 80)) 
          //  {
                //Console.WriteLine("Contains");
           // } else
           //     {
              //Console.WriteLine("not contains");
             //   }
        }
    }
}