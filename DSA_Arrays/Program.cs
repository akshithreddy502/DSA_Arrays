
int[] arr = new int[20];
arr[0] = 12;
arr[1] = 16;
arr[2] = 20;
arr[3] = 40;
arr[4] = 50;
arr[5] = 70;
int n = 6;
for (int i=0; i<n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
int key = 80;


n = insertElement(arr, key, n);

for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
static int insertElement(int[] arr, int key, int n)
{
    if (n > arr.Length - 1)
        return n;

    arr[n] = key;
    return n + 1;

}