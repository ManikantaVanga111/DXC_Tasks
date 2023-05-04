namespace Linq_query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define datesource
            string[] fruits = { "Apple","Watermelon","Guava","Mango","Cherry","Banana","Pineapple","Orange" };
            // define query
            //var query=from f in fruits where f.Length%2==0 select f;
            // var query = from f in fruits where f.Length == 6 select f; 
            //  var query = from f in fruits orderby f select f;
           // var query = from f in fruits orderby f descending select f;
           var query =from f in fruits where f.StartsWith('G') select f;
            foreach (var item in query)
            Console.WriteLine(item);
        }
    }
}