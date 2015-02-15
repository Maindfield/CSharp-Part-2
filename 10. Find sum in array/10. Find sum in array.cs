using System;

            //Write a program that finds in given array of integers a sequence of given sum S (if present).

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter array on one line with space: ");
        string[] line = Console.ReadLine().Split(' ');

        int[] arr = new int[line.Length];

        for (int i = 0; i < line.Length; i++)
        {
            arr[i] = int.Parse(line[i]);
        }
        
        Console.Write("Enter sum: ");
        int s = int.Parse(Console.ReadLine());
       
        int sum = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
           
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j]; 

                if (sum == s)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(arr[k] + " ");
                    }
                    i = j;
                    Console.WriteLine();
                    sum = arr[i]; 
                }
            }
            sum = 0;
        }
    }
}

