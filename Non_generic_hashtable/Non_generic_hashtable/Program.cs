using System.Collections;
namespace Non_generic_hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Hashtable ht = new Hashtable();
            ht.Add(4, "four");
            ht.Add(3, "Three");
            ht.Add(5, "five");
            ht.Add(1, "one");
            ht.Add(2, "two");
            foreach (int key in ht.Keys) {
                Console.WriteLine($"{key}, {ht[key]}");
            }
            Console.WriteLine();
            ht.Add(6, "hi");
            foreach (int key in ht.Keys)
            {
                Console.WriteLine($"{key}, {ht[key]}");
            }

        }
    }
}