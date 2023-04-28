using System.Collections;
namespace Nongeneric_arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {

        ArrayList list = new ArrayList();
            list.Add(1);    
            list.Add(2);
            list.Add("HI");
            list.Add("bye");
            foreach (var i in list) //var or Object
                                    //var is not a data type its just a keyword declaring for variables
                                    //object is a universal data type 
            {
                Console.WriteLine(i);
                 }
            Console.WriteLine(list.Count);

            list.Insert(2, "all");
            foreach (Object i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.Count);

            Console.WriteLine("");
            Console.WriteLine(list[3]);
        }
            
    }
}