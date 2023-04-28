using System.Collections;
namespace Nongeneric_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(5);
            s.Push(6);
            s.Push(7);
            s.Push(8);
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
           Console.WriteLine($"pop is {s.Pop()}");
            Console.WriteLine($"pop is {s.Pop()}");
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
}