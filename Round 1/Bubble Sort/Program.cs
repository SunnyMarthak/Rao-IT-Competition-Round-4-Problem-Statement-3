Console.Write("Enter Length of Array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < arr.Length; i++)
{
    for(int j = 0;j< arr.Length - i - 1; j++)
    {
        if(arr[j] > arr[j + 1])
        {
            int temp = arr[j + 1];
            arr[j + 1] = arr[j];
            arr[j] = temp;
        }
    }
}
Console.WriteLine(string.Join(",", arr));