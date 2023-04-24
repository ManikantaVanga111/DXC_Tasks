// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the elements");
int[] arr=new int[10];
float sum = 0;
for(int i=0; i<arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());

}
for(int i=0 ; i<arr.Length ; i++)
{
    sum = sum + arr[i];
    
}
double avg=(sum/arr.Length);
Console.WriteLine($"Average of the array is {avg}");
