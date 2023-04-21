// See https://aka.ms/new-console-template for more information
/*
for (int i = 1; i <=10; i++) {
    Console.WriteLine("Enter celsius");
    int c=Convert.ToInt16(Console.ReadLine());
    double f = (c * 1.8) + 32;
    Console.WriteLine("S.No Celsius Fahrenheit ");
    Console.WriteLine($"{i}     {c}     {f}");
}
*/
/*for (int c = 0; c <100; c += 10)
{
    double f = (c * 1.8) + 32;
    Console.WriteLine($"{c}  {f}");
}*/
int c = 0;
int i = 0;
while(c<100)
{
    
    i++;
    double f = (c * 1.8) + 32;
    Console.WriteLine("S.No Celsius Fahrenheit ");
    Console.WriteLine($"{i}     {c}       {f}");
    c += 10;
}
   

