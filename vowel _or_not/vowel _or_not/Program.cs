// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Enter the character");
char ap=Convert.ToChar(Console.ReadLine());
if(ap == 'A' || ap =='a' || ap=='e' || ap=='E' ||ap=='i' || ap=='I' || ap=='o' ||ap=='O' ||ap =='u' || ap=='U' )
{
    Console.WriteLine("It's an vowel");
} else 
{
    Console.WriteLine("It's not an vowel");
}

