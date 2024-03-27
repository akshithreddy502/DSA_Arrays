class Program
{
    //Easy Questions

    //1)Find Largest Element in an array

    //BruteForce - Sort the array in descending order and get last element as largest
    //Optimal approach

    static int LargestElement(int[] arr)
    {
        int largest = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
        }
        Console.WriteLine($"The largest element in an array is {largest}");
        return largest;
    }


    //2)Second Largest element in array
    static int SecondLargest(int[] arr)
    {
        int largest = arr[0];
        int secondLargest = -1;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            //[1,2,4,7,7,5] suppose for this example 5 is not larger than largest. so we skip it but it can be second largest.
            else if (arr[i] < largest && arr[i] > secondLargest)
            {
                secondLargest = arr[i];
            }
        }
        Console.WriteLine($"The second largest element in an array is {secondLargest}");
        return secondLargest;

    }

    //3)

    //4) Remove duplicates from Sorted Array  Leetcode 26
    //BruteForce
    static int RemoveDuplicatesFromSortedArray(int[] arr)
    {
        //Declared HashSet to store unique elements
        HashSet<int> hashset = new HashSet<int>();
       
        //adding all elements to hashSet. duplicates will not be added.
        for(int i=0; i < arr.Length; i++)
        {
            hashset.Add(arr[i]);   // Time Complexity for adding to Set is O(nlogn)
        }
        int index = 0;
        foreach(int uniqueEle in hashset)
        {
            arr[index] = uniqueEle;
            index++;   //// Time Complexity for adding to array from Set is O(n)
        }
        return hashset.Count;
    }

    //OPtimal Approach

    static int RemoveDuplicates(int[] arr)
    {
        int i = 0;
        for(int j=1; j < arr.Length; j++)
        {
            //first element is not required to check bec it is not dupliacte
            if (arr[i] != arr[j])
            {
                i++;
                arr[i] = arr[j];
            }
        }
        // As array is Zero based Indexed
        return i + 1;
    }


    //5) Left rotate an array by 1 place
    // simple i index element will be placed in i-1
    static int[] LeftRotateAnArrayBy1Place(int[] arr)
    {
        int temp = arr[0];
        for(int i=1; i < arr.Length; i++)
        {
            arr[i - 1] = arr[i];
        }
        arr[arr.Length - 1] = temp;
        return arr;
    }

    //6) Left rotate an array by D places
    //BruteForce Approach
    //has a time complexity of O(N) and requires extra space for the temporary array, where N is the size of the input array.
    static int[] LeftRotateAnArrayByDPlaces(int[] arr,int d)
    {
        // 1) Store 1st d elements in Temp array
        int[] tempArray = new int[d];
        for(int i=0;i< tempArray.Length; i++)
        {
            tempArray[i] = arr[i];
        }

        // move next  elements d places left
        for(int i = d; i< arr.Length; i++)  // we have stored 0th,1st and 2nd index elements in temp array. now we need to start at d index
        {
            arr[i - d] = arr[i];  // i=3 and d=3 i-d = 0th index, i=4 and d=3 i-d = 1st index
        }

        //Get the temp elements and store in last places (n-d) places
        int j = 0;
        for(int i = arr.Length-d; i< arr.Length; i++)
        {       
            arr[i] = tempArray[j];
            j++;
        }
        return arr;
    }

    //Optimal Approach
    static void Reverse(int[] arr, int start, int end)
    {
        int n = arr.Length;
        while (start <=end) { 
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
    static int[] RotateArrayByD(int[] arr, int d)
    {
        //Reverse 1st 3 elements
        Reverse(arr, 0, d - 1);
        //Reverse remaining elements
        Reverse(arr, d, arr.Length - 1);
        //Reverse whole array
        Reverse(arr, 0, arr.Length - 1);
        return arr;
    }





    // Right rotate an array by k places
   
        static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; // Adjust k to handle cases where k is greater than the length of the array

            Reverse1(nums, 0, n - 1); // Reverse the entire array
            Reverse1(nums, 0, k - 1); // Reverse the first part up to k(reverse 1st k elements ) ==> same like above 
            Reverse1(nums, k, n - 1); // Reverse the remaining part after k  ==> same like above
        }
    static void Reverse1(int[] arr, int start, int end)
        {
            int n = arr.Length;
            while (start <= end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    






    //7) Move Zeros  // 2 pointer approach => i will be index where we put numbers and increment accordingly
    //Leetcode 283 - MOve Zeros
    static int[] MoveZeros(int[] arr)
    {
        int i = 0;
        //swap 0 element with next element and move 
        for(int j=1; j < arr.Length; j++)
        {
            if (arr[j] != 0)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
            }
        }
        return arr;
    }

    //8) Linear Search
    static int LinearSearch(int[] arr, int k)
    {
        for(int i=0; i< arr.Length; i++)
        {
            if (arr[i] == k)
            {
                return i;
            }
        }
        return -1;
    }

    //9)Union of 2 Arrays
    // BRUTE FORCE APPROACH

    static int[] UnionOf2Arrays(int[] arr1, int[] arr2)
    {
        //Step1
        //Declared an Hashset to store unique elements
        HashSet<int> hashset = new HashSet<int>();
        int n1 = arr1.Length;
        int n2 = arr2.Length;
        //Add 1st array elements to Hashset
        for(int i = 0; i < n1; i++)
        {
            hashset.Add(arr1[i]); // each element to add takes logn times. so for n elements Time Complexity is n*logn
        }
        for(int j=0; j< n2; j++)
        {
            hashset.Add(arr2[j]); // each element to add takes logm times. so for m elements Time Complexity is m*logm
        }

        //Step2
        //Decalre an array of size Hashset and iterate thorugh hashset and store in new array
        //Time Complexity is O(n+m)
        int[] unionArray = new int[hashset.Count];
        int ind = 0;
        foreach(var ele in hashset)
        {
            unionArray[ind] = ele;
            ind++;
        }
        return unionArray;
    }

    // Time Complexity: O(n*logn + m*logm) + O(m+n)
    //Space Complexity : Auxiliary space - O(m+n) // for creating a new array and storing m and n elements

    //Optimal Approach
    //using 2 Pointers
    static List<int> printUnion(int[] arr1, int[] arr2)
    {
        int n1 = arr1.Length;
        int n2 = arr2.Length;
        List<int> unions = new List<int>();
        int i = 0, j = 0;
        while(i<n1 && j < n2)
        {
            if (arr1[i] < arr2[j])
            {
                if (unions.Count == 0 || unions[unions.Count - 1] != arr1[i])
                    unions.Add(arr1[i]);
                i++;
            }
            if (arr2[j] < arr1[i])
            {
                if (unions.Count == 0 || unions[unions.Count - 1] != arr2[j])
                    unions.Add(arr2[j]);
                j++;
            }
            else
            {  // this condition is when both elements in arr1 and arr2 are equal arr1[i] == arr2[j]
                if (unions.Count == 0 || unions[unions.Count - 1] != arr1[i])
                    unions.Add(arr1[i]);
                i++;
                j++;
            }
        }
        // Add remaining elements of arr1, if any
        while (i < n1)
        {
            if (unions.Count == 0 || unions[unions.Count - 1] != arr1[i])
                unions.Add(arr1[i]);
            i++;
        }
        // Add remaining elements of arr2, if any
        while (j < n2)
        {
            if (unions.Count == 0 || unions[unions.Count - 1] != arr2[j])
                unions.Add(arr2[j]);
            j++;
        }
        return unions;
    }

    // Time complexity = > O(m+n)  // we need to iterate through m elements of i and n elements of j
    // Space complexity = > O(m+n)  for union list


    static List<int> FindIntersection(int[] arr1, int[] arr2)
    {
        List<int> intersection = new List<int>();
        int n1 = arr1.Length;
        int n2 = arr2.Length;
        int i = 0, j = 0;
        while(i<n1 && j < n2)
        {
            if (arr1[i] < arr2[j])
            {
                i++;
            }
            if (arr2[j] < arr1[i])
            {
                j++;
            }
            else  // arr1[i] == arr2[j]
            {
                intersection.Add(arr1[i]);
                i++;
                j++;
            }
        }
        return intersection;
    }
    // Time complexity = > O(m+n)  // we need to iterate through m elements of i and n elements of j
    // Space complexity = > O(m+n)  for intersection list




    //10) Find missing number in an array
    //Leetcode 268
    //BruteForce
    static int FindMissingNumber(int[] arr)
    {
        for(int i=1; i < arr.Length; i++)
        {
            bool found = false;
            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == i)
                {
                    found = true;
                    break;
                }
               
            }
            if (!found)
            {
                return i;
            }
        }
        return -1;
    }

    //Optimal Approach
    static int FindMissingNum(int[] arr, int n)
    {
        
        int sum = n * (n + 1) / 2;
        int currentSum = 0;
        for(int i=0;i< arr.Length; i++)
        {
            currentSum += arr[i];
        }
        return sum - currentSum;
    }

    //OPtimal Approach
    static int FindMissingNumXOR(int[] arr, int n)
    {
        int xor1 = 0;
        for(int i = 1; i <= n; i++)
        {
            xor1 = xor1 ^ i;
        }
        int xor2 = 0;
        for (int i = 0; i < n-1; i++)
        {
            xor2 = xor2 ^ arr[i] ;
        }
        return xor1 ^ xor2;
    }



    // 11- Maximum Consequetive ones  - Leetcode 485
    static int MaximumConsequetiveOnes(int[] arr)
    {
        int count = 0, maxCount = 0; // count how many 1s
        for(int i=0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                count += 1;
                maxCount = Math.Max(count, maxCount);
            }
            else
            {
                count = 0;
            }
           

        }
        return maxCount;
    }

    //12 - Fin the number that appears once  - leetcode 136
    //Brute Force Approach
    //It does so by iterating through each element in the array and counting the number of times it appears.
    static int SingleNumber(int[] arr)
    {
        for(int i=0; i< arr.Length; i++)
        {
            int count = 0;
            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == arr[i])
                {
                    count += 1;
                }
            }
            if(count == 1)
            {
                return arr[i];
            }
        }
        return -1;
    }

    //Better Approach

    static int SingleNumberHashMap(int[] arr)
    {
        Dictionary<int, int> mapFrequency = new Dictionary<int, int>();
        for(int i=0; i < arr.Length; i++)
        {
            if( mapFrequency.ContainsKey(arr[i])){
                mapFrequency[arr[i]]++;
            }
            else
            {
                mapFrequency[arr[i]] = 1;
            }
        }
        foreach(var ele in mapFrequency)
        {
            if(ele.Value == 1)
            {
                return ele.Key;
            }
        }
        return -1;
       
    }

    //Optimal Approach
    static int SingleNumberXOR(int[] arr)
    {
        int xor = 0;
        for(int i=0; i< arr.Length; i++)
        {
            xor = xor ^ arr[i];
        }
        return xor;
    }








    static int[] NextGreaterElement(int[] arr)
     {
        int n = arr.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();
        for (int i = n - 1; i >= 0; i--)
        {
            while(stack.Count !=0 && stack.Peek() <= arr[i])
            {
                stack.Pop();
            }
            if(stack.Count !=0 && stack.Peek() > arr[i])
            {
                result[i] = stack.Peek();
            }
            else
            {
                result[i] = -1;
            }
            stack.Push(arr[i]);
        }
        return result;
     
     }



    static void Main(string[] args) { 
        int[] arr = { 2, 5, 1, 3, 0 };
        LargestElement(arr);
        int[] secLargest = { 1, 2, 4, 7, 7, 5 };
        SecondLargest(secLargest);
        int[] leftRotateby1 = { 1, 2, 3, 4, 5 };
        // int[] leftRot = LeftRotateAnArrayBy1Place(leftRotateby1);
        //for(int i=0;i< leftRot.Length; i++)
        //{
        //Console.WriteLine(leftRot[i]);
        //}
        //int[] leftRotatebyD = { 1, 2, 3, 4, 5,6,7};
        // int[] leftRotbyD = RotateArrayByD(leftRotatebyD, 3);
        // for (int i = 0; i < leftRotbyD.Length; i++)
        // {
        //  Console.WriteLine(leftRotbyD[i]);
        //}
        int[] linearscrch = { 1, 2, 3, 4, 5 };
       // LinearSearch(linearscrch, 3);
        int[] unionarr1 = { 1, 2, 3, 4, 5 };
        int[] unionarr2 = { 2, 3, 4, 4, 5 };
        // int[] unionArr = UnionOf2Arrays(unionarr1, unionarr2);
        //List<int> retUnion = printUnion(unionarr1, unionarr2);
        //foreach(var arr1 in retUnion)
        //{
          //  Console.Write(arr1);
        //}
        int[] missing = {1,2,4,5};
        //int missingNumber = FindMissingNum(missing,5);
       // Console.WriteLine($"Missing Number is {missingNumber}");
       // int missingNumberXOR = FindMissingNumXOR(missing, 5);
       // Console.WriteLine($"Missing Number is {missingNumberXOR}");
        int[] max1s = { 1, 1, 0, 1, 1, 1 };
        // int max1sCount = MaximumConsequetiveOnes(max1s);
        // Console.WriteLine($"MaximumConsequetiveOnes  is {max1sCount}");
        int[] single1 = { 4, 1, 2, 1, 2 };
        int[] single2 = { 2, 2, 1 };
        Console.WriteLine($"Single 1 is {SingleNumber(single2)}");
        Console.WriteLine($"Single using Hashmap is {SingleNumberHashMap(single1)}");
        Console.WriteLine($"Single using XOR is {SingleNumberXOR(single1)}");
    }
}