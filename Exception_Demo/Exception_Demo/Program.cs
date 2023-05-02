namespace Exception_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the a value");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the b velue");
            int b=Convert.ToInt32(Console.ReadLine());
            int c=0;
            try
            {
                c = a / b;
                // Console.WriteLine(c);
                try
                {
                    if (a < b)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("first number is smaller than the second number");
                }
            }
            catch(DivideByZeroException) {
                Console.WriteLine("Don't give zero");

            }
         
            Console.WriteLine(c);
        }
    }
}