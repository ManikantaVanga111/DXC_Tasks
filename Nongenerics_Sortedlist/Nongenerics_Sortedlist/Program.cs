using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add(4, "Four");
            list.Add(1, "One");
            list.Add(3, "Three");
            list.Add(2, "Two");
            list.Add(5, "Five");

            Console.WriteLine(list[1]);//key value
            Console.WriteLine(list.GetKey(3));


            foreach (var item in list.Keys)
            {
                Console.WriteLine($"Key: {item}, Value: {list[item]}");
            }

            Console.WriteLine(list.GetKey(3));
            Console.WriteLine(list[4]);
        }
    }
}