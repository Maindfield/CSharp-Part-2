using System;

//Write a program that finds the most frequent number in an array.
class FrequentNumber
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

        int count = 0;
        int max = 0;
        int result = 0;

        for (int i = 0; i < line.Length - 1; i++)
        {
            for (int j = i; j < line.Length; j++)
            {
                if (line[i] == line[j])
                {
                    count++;
                }
                if (count > max)
                {
                    max = count;
                    result = line[i];
                }
            }
            count = 0;
        }
        Console.WriteLine("[{0}] [{1}] times)", result, max);
    }
}