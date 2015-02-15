using System;

//Write a program that sorts an array of integers using the Quick sort algorithm.

class QuickSort
{

    static void Main(string[] args)
    {
        Console.Write("Enter array length: ");
        int len = int.Parse(Console.ReadLine());
        int[] numbers = new int[len];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter array number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("QuickSort By Recursive Method");
        QuickSort_Recursive(numbers, 0, len - 1);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + ", ");
        }
        Console.WriteLine();
    }
    static public int Partition(int[] numbers, int left, int right)
    {

        int pivot = numbers[left];

        while (true)
        {
            while (numbers[left] < pivot)
            {
                left++;
            }
            while (numbers[right] > pivot)
            {
                right--;
            }
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSort_Recursive(int[] arr, int left, int right)
    {
        // For Recusrion
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSort_Recursive(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSort_Recursive(arr, pivot + 1, right);
            }
        }
    }
}

