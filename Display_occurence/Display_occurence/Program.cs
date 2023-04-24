int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6,6};
int most = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > most)
    {
        most = arr[i];
    }
}
int[] j = new int[most + 1];
for (int i = 0; i <= most; i++)
{
    j[i] = 0;
}
for (int i = 0; i < arr.Length; i++)
{
    j[arr[i]]++;
}
int k = 0;
for (int i = 0; i <= most; i++)
{
    if (j[i] > k)
    {
        k = j[i];
    }
}
Console.WriteLine("Elements that occur most frequently");
for (int i = 0; i <= most; i++)
{
    if (j[i] == k)
    {
        Console.WriteLine(i);




    }
}