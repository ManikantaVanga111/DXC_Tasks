int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
int most = 0;
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    int most1 = arr[0];
    int count1 = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] == most1)
        {
            count1++;
        }
        if (count1 > count)
        {
            most = most1;
            count = count1;
        }
    }
}
Console.WriteLine(most);