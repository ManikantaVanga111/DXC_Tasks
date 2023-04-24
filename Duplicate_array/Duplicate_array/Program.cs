// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the elements");
int[] arr=new int[9];  
for(int i=0; i<arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < arr.Length; i++)
{
    for(int j=i+1; j<arr.Length; j++)
    if (arr[i] == arr[j])
    {
 
        Console.WriteLine(arr[j]);
    }
    
}

