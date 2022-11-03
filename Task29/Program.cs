System.Console.WriteLine("Enter the number of elements in the array:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(n, array);
void FillArray(int n, int[]a)
{
    for (int i = 0; i < n; i++)
    {
        a[i] = new Random().Next(-100, 100);
    }
}
for (int i = 0; i < n; i++) System.Console.WriteLine(array[i]);