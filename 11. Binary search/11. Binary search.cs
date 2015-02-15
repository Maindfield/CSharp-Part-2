using System;

                //Write a program that finds the index of given element in a sorted array of 
                //integers by using the Binary searchalgorithm.
class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter array on one line with space: ");
        string[] arrStr = Console.ReadLine().Split(' ');

        int[] arr = new int[arrStr.Length];

        for (int i = 0; i < arrStr.Length; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }

        Array.Sort(arr);
        Console.WriteLine("Sorted array:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.Write("Enter integer to search for: ");
        int num = int.Parse(Console.ReadLine());

        int startIndx = 0;
        int endIndx = arr.Length;

        while ((endIndx - startIndx) > 1)
        {
            int indx = startIndx + (endIndx - startIndx) / 2;
            if (arr[indx] == num) 
            { 
                Console.WriteLine("{0} is at index {1}", num, indx);
                return;
            }
            else if (arr[indx] > num)
            {
                endIndx = indx;
            }
            else if (arr[indx] < num)
            {
                startIndx = indx;
            }
        }
        Console.WriteLine("Not found!");
    }
}
