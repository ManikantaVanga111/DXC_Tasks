namespace celsius_to_fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Celsius");
            int Celsius = Convert.ToInt16(Console.ReadLine());
            double F = (Celsius * 1.8) + 32;
            Console.WriteLine(F);
        }
    }
}