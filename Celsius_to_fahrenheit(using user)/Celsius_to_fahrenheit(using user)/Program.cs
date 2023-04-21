// See https://aka.ms/new-console-template for more information
char ch;
do
{
    Console.WriteLine("Enter the temperature in Degree celsius");
    int c = Convert.ToInt16(Console.ReadLine());
    double f = (c * 1.8) + 32;
    Console.WriteLine($"Temperature(celsius)={c} Temperature(fahrenheit)={f}");
    Console.WriteLine("Do u wish to continue (y/n)");
    ch = Convert.ToChar(Console.ReadLine());
}while(ch =='y'|| ch=='Y');
Console.WriteLine($"You choosed the unnecessary option i.e. {ch}");


/*
if(ch=='y')
{
    Console.WriteLine("Enter the temperature in Degree celsius");
    int C = Convert.ToInt16(Console.ReadLine());
    double F= (C* 1.8) + 32;
    Console.WriteLine($"Temperature(celsius)={c} Temperature(fahrenheit)={f}");
} else if(ch=='n')
{
    Console.WriteLine($"Thanks for choosing the required option i.e. {ch}");
} else
{
    Console.WriteLine("Choose the required Option");
}
*/
/*
while(ch=='y')
{
    Console.WriteLine("Enter the temperature in Degree celsius");
    int C = Convert.ToInt16(Console.ReadLine());
    double F = (C * 1.8) + 32;
    Console.WriteLine($"Temperature(celsius)={c} Temperature(fahrenheit)={f}");
    break;
}
Console.WriteLine($"Thanks for choosing the required option i.e. {ch}");
*/


