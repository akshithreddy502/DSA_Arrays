

//HEAP SORT

int[] arr = { 12, 11, 13, 5, 6, 7 };
Console.WriteLine("Original array:");
Console.WriteLine(string.Join(", ", arr));

HeapSort(arr);

Console.WriteLine("Sorted array:");
Console.WriteLine(string.Join(", ", arr));

static void HeapSort(int[] arr)
{
    int n = arr.Length;
    for(int i= n/2 -1; i >=0; i--)
    {
        Heapify(arr, n, i);
    }
    for(int i = n-1; i> 0; i--)
    {
        int temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;
        Heapify(arr, n, 0);
    }
}
static void Heapify(int[] arr, int n, int i)
{
    int largest = i;
    int left = 2 * i + 1;
    int right = 2 * i + 2;
    if(left < n && arr[left] > arr[largest])
    {
        largest = left;
    }
    if (right < n && arr[right] > arr[largest])
    {
        largest = right;
    }
    if(largest != i)
    {
        int swap = arr[i];
        arr[i] = arr[largest];
        arr[largest] = swap;
        // Recursively heapify the affected sub-tree
        Heapify(arr, n, largest);
    }
   
}


















































/*
//SELECTION SORT:
int[] arr = { 64,25,12,22,11 };

int n = arr.Length;
int key = 30;

Console.Write("Array before deletion:\n");
for (int i = 0; i < n; i++)
    Console.Write(arr[i] + " ");

// Function call
selectionSort(arr, n);

Console.Write("\n\nArray after deletion:\n");
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
    
}
Console.WriteLine("");

static void selectionSort(int[] arr, int n)
{
    for(int i=0; i<n;i++)
    {
        int min_idx = i;
        for(int j=i+1; j< n; j++)
        {
            if (arr[j] < arr[min_idx])
            {
                min_idx = j;
            }
        }
        int temp = arr[min_idx];
        arr[min_idx] = arr[i];
        arr[i] = temp;

    }
}

*/


//Deleting element in sorted array using binary search

/*int i;
int[] arr = { 10, 20, 30, 40, 50 };

int n = arr.Length;
int key = 30;

Console.Write("Array before deletion:\n");
for (i = 0; i < n; i++)
    Console.Write(arr[i] + " ");

// Function call
n = deleteElement(arr, n, key);

Console.Write("\n\nArray after deletion:\n");
for (i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}


static int deleteElement(int[] arr, int n, int key)
{
    int low = 0;
    int high = n - 1;
    int eleIndex = findElementIndex(arr, n, key, low, high);
    for (int i = eleIndex; i < n - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    return n - 1;
}

static int findElementIndex(int[] arr, int n, int key, int low, int high)
{
    int mid = low + high / 2;
    if (arr[mid] == key)
    {
        return mid;
    }
    else if (arr[mid] < key)
    {
        low = mid + 1;
        return findElementIndex(arr, n, key, low, high);
    }
    else
    {
        high = mid - 1;
        return findElementIndex(arr, n, key, low, high);
    }
    return -1;
}
*/










//Deleting element using linear search

/*int i;
int[] arr = { 10, 50, 30, 40, 20 };

int n = arr.Length;
int key = 30;

Console.Write("Array before deletion ");
for (i = 0; i < n; i++)
    Console.Write(arr[i] + " ");
Console.WriteLine();

// Function call
n = deleteElement(arr, n, key);

Console.Write("Array after deletion ");
for (i = 0; i < n; i++)
    Console.Write(arr[i] + " ");

static int deleteElement(int[] arr, int n, int key)
{
    int eleIndex = findElementIndex(arr,n,key);
    for(int i= eleIndex; i < n-1; i++)
    {
        arr[i] = arr[i + 1];
    }
    return n - 1;
}

static int findElementIndex(int[] arr, int n, int key)
{
    for(int i=0; i<n; i++)
    {
        if (arr[i] == key)
        {
            return i;
        }
    }
    return -1;
}

*/









// searching element using binary search in sorted array

/*int[] arr = new int[] { 5, 6, 7, 8, 9, 10 };
int n, key;
n = arr.Length;
key = 10;
int low = 0;
int high = n - 1;
int returnedIndex = BinarySearch(arr, key, low, high);
if (returnedIndex == -1)
{
    Console.WriteLine("Element not found");
}
else
{
    Console.WriteLine("Element  found");
}

static int BinarySearch(int[] arr, int key, int low, int high)
{
    while(low <= high)
    {
        int mid = (low + high) / 2;
        if (arr[mid] == key)
        {
            return mid;
        }
        else if (arr[mid] < key)
        {
             low = mid + 1;
           return BinarySearch(arr, key, low, high);
        }
        else
        {
            high = mid - 1;
           return BinarySearch(arr, key, low, high);
        }
    }
    return -1;
}




*/
//Searching element using Linear search in an unsorted array
/* int[] arr = { 12, 34, 10, 6, 40 };
int n = arr.Length;
int key = 40;
int a= searchElement(arr, n, key);
if (a == -1)
{
    Console.WriteLine("Element not found");
}
else
{
    Console.WriteLine("Element  found");
}
static int searchElement(int[] arr, int n,int key)
{
    for(int i = 0; i < n ; i++)
    {
        if (arr[i] == key)
        {
            return i;
        } 
        
    }
    return -1;
}
*/





//Inserting element at the position
/*int[] arr = new int[20];
arr[0] = 12;
arr[1] = 16;
arr[2] = 20;
arr[3] = 40;
arr[4] = 50;
arr[5] = 70;
int n = 6;
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
int pos = 3;
int key = 30;


n = insertElementPos(arr, key, n, pos);

for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
static int insertElementPos(int[] arr, int key, int n, int pos)
{
    if (n > arr.Length)
        return n;

    for (int i = n - 1; i >= pos; i--)
    {
        arr[i + 1] = arr[i];
    }
    arr[pos] = key;
    return n + 1;
}
*/






/*
 * Inserting element at the end 
 * 
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
    if (n > arr.Length )
        return n;

    arr[n] = key;
    return n + 1;

}


*/