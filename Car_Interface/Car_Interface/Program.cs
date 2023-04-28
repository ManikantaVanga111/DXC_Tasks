namespace Car_Interface
{

  
    interface IVehiculo
    {
        void Drive();

        bool Refuel(int value);
    }

    class Car : IVehiculo
    {
        int g;
        public Car(int Gasoline)
        {
            g = Gasoline;
        }

        public void Drive()
        {
            if (g > 0)
            {
                Console.WriteLine("The car is driving");
            }
            else
            {
                Console.WriteLine("The car is not driving");

            }
        }

        public bool Refuel(int gas)
        {
            g += gas;
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of gasoline to refuel: ");
            int gas= Convert.ToInt16(Console.ReadLine());

            Car myCar = new Car(0);
            myCar.Refuel(gas);
            myCar.Drive();
        }
    }
}