// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Enter student ID");
int StudentID=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter student name");
String StudentName = Console.ReadLine();
Console.WriteLine("Enter student age");
int StudentAge=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter marks1");
int marks1=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter marks2");
int marks2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter marks3");
int marks3 = Convert.ToInt16(Console.ReadLine());
float total = marks1 + marks2 + marks3;
Console.WriteLine("Total score is {0} ", total);
float avg = total / 3;
Console.WriteLine("Average is " + avg);
//float percentage = (total/300) * 100;
//Console.WriteLine("The percentage is " + percentage);
if(avg>=90 &&  avg<= 100)
{
    Console.WriteLine("Grade is A");
} else if(avg>=80 && avg<=89)
{
    Console.WriteLine("Grade is B");
} else if (avg>=60 && avg<=79)
{
    Console.WriteLine("Grade is C");
}else if(avg>=50 && avg<=59)
{
    Console.WriteLine("Grade is D");
} else
{
    Console.WriteLine("Grade is E");
}
if(avg>50)
{
    Console.WriteLine("Result for the exam is Pass");
} else
{
    Console.WriteLine("Result for the exam is fail");
}


