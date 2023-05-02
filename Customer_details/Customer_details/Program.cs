using System.Net.Http.Headers;

namespace Customer_details
{
    class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
        public string Phoneno { get; set; }
        public string city { get; set; }
        public string Id { get; set; }
    }
    class Management
    {
        List<Customer> customers=new List<Customer>();
        public void AddDetails()
        {
            Console.WriteLine("Enter firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter mail");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phoneno");
            string phoneno = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            string id = Convert.ToString(firstname[0] + lastname[0] + phoneno[3]);
            Console.WriteLine(id);
           customers.Add(new Customer { Firstname = firstname, Lastname = lastname, Mail = mail, Age = age, Phoneno = phoneno, city = city, Id = id });
        }
        public void GetDetails() 
        {
            foreach (Customer c in customers)
       
                Console.WriteLine ($"{c.Id} {c.Firstname} {c.Lastname} {c.Mail} {c.Age} {c.city} {c.Phoneno}");
            
        }
        public void UpdateDetails()
        {
            Console.WriteLine("Enter id");
            string id=Console.ReadLine();
            foreach (Customer c in customers)
            {
                if(c.Id.Equals(id))
                {
                    Console.WriteLine("Enter first name");
                    c.Firstname = Console.ReadLine();
                    Console.WriteLine("Enter last name");
                    c.Lastname = Console.ReadLine();
                    Console.WriteLine("Enter AGE name");
                    c.Age =Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("Enter mail name");
                    c.Mail = Console.ReadLine();
                    Console.WriteLine("Enter phone number");
                    c.Phoneno = (Console.ReadLine());
                    Console.WriteLine("Enter city name");
                    c.city = Console.ReadLine();

                }
               
            }
            
        }
        public bool DeleteDetails()
        {
            Console.WriteLine("Enter age");
            int age=Convert.ToInt32( Console.ReadLine());  
            foreach (Customer c in customers) { 
                if(c.Age == age) 
                {
                    customers.Remove(c);
                    return true;
                }
            }
            return false;
        }
        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
           Management sc= new Management();
            
            while (true)
            {
                Console.WriteLine("1 for Accept details");
                Console.WriteLine("2 for Get Datails");
                Console.WriteLine("3 for Updatedetails");
                Console.WriteLine("4 for DeletingDetails");
                Console.WriteLine("Enter num");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        {
                            sc.AddDetails();
                            break;
                        }
                    case 2:
                        {
                            sc.GetDetails();
                            break;

                        }
                    case 3:
                        {

                            sc.UpdateDetails();
                            break;
                        }
                    case 4:
                        {
                            if (sc.DeleteDetails())
                            {
                                Console.WriteLine("successfully deleted");
                            } else
                            {
                                Console.WriteLine("Age is Not found");
                            }
                            
                            break;
                        }
                   default:
                        {
                            Console.WriteLine("Enter valid one");
                            break;
                        }
                }
            }
           
      
            
        }
    }
}