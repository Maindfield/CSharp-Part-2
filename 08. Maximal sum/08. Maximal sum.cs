using System;

//Write a program that finds the sequence of maximal sum in given array.

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int input = int.Parse(Console.ReadLine());

        int[] line = new int[input];
        for (int i = 0; i < line.Length; i++)
        {
            Console.Write("Enter array number: ");
            line[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int maxSum = int.MinValue;
        int start = 0;
        int bestStart = 0;
        int end = 0;


        for (int index = 0; index < line.Length; index++)
        {
            if (sum <= 0)
            {
                start = index;
                sum = 0;
            }
            sum += line[index];
            if (sum > maxSum)
            {
                maxSum = sum;
                bestStart = start;
                end = index;
            }
        }
        Console.WriteLine("Maximal sum is: {0}", maxSum);
        Console.WriteLine("Sequence start at index[{0}], sequence end at index[{1}]", bestStart, end);
    }
}




