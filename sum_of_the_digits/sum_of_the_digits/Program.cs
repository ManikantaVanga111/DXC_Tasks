// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number");
int num=Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num > 0)
{
    int remainder = num % 10;
     sum=sum+remainder; ;
    num = num/10;
    
}
Console.WriteLine("Sum of the digits is " + sum);
