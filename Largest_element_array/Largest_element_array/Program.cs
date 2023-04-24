// See https://aka.ms/new-console-template for more information
int[] arr = new int[] { 7, 4, 5, 6, 8, 2, 3, 1 };
int max = arr[0];
for (int i = 0; i < arr.Length; i++) {
    if (max < arr[i])
    {
        max = arr[i];
    }
        }
Console.WriteLine($"The largest number from given array {max}");
