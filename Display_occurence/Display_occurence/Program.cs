int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6};
int max = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
int[] arr1 = new int[max + 1];
for (int i = 0; i <= max; i++)
{
    arr1[i] = 0;
}
for (int i = 0; i < arr.Length; i++)
{
    arr1[arr[i]]++;
}
int k = 0;
for (int i = 0; i <= max; i++)
{
    if (arr1[i] > k)
    {
        k = arr1[i];
    }
}
Console.WriteLine("Elements that occur most frequently");
for (int i = 0; i <= max; i++)
{
    if (arr1[i] == k)
    {
        Console.WriteLine(i);
 }
}