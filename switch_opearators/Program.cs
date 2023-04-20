// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

Console.WriteLine("Enter first number");
int a=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the opearator");
char ch = Convert.ToChar(Console.ReadLine());
switch(ch)
{
    case '+':
        {
            Console.WriteLine("Result is "+( a + b));
            break;    
        }
    case '-':
        {
            Console.WriteLine("Result is "+(a - b));
            break;
        }
    case '*':
        {
            Console.WriteLine("Result is " +(a * b));
            break;
        }
    case '/':
        {
            Console.WriteLine("Result is "+(a / b));               
            break;
        }
    case '%':
        {
            Console.WriteLine("Result is "+(a % b));   
            break;
        }
    default: {
            Console.WriteLine("Enter the valid operator");
            break;
        }

}
