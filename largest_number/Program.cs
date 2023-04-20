// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the second number");
int b = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the third number");
int c = Convert.ToInt16(Console.ReadLine());
if(a>b && a>c)
{
    Console.WriteLine("a is largest");
}else if(b>a && b>c)
{
    Console.WriteLine("b is largest");
} else
{
    Console.WriteLine("c is greater");
}

