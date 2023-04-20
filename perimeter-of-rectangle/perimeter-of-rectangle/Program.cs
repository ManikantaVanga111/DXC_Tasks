namespace perimeter_of_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  Console.WriteLine("Enter Length and breadth of the rectangle");
            int  Length=Convert.ToInt16(Console.ReadLine());
            int breadth = Convert.ToInt16(Console.ReadLine());
            int P=2 *(Length + breadth);
          Console.WriteLine(P);
          */
          
            Console.WriteLine("Enter Length and breadth of the rectangle");
            float  Length=Convert.ToSingle(Console.ReadLine());
            float breadth =Convert.ToSingle(Console.ReadLine());
            float P=(2*(Length + breadth));
            Console.WriteLine(P);



        }
    }
}