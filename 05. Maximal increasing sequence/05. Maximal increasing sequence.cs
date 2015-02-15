using System;

//Write a program that finds the maximal sequence of equal elements in an array.

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter array length:");
        int input = int.Parse(Console.ReadLine());

        int[] line = new int[input];

        Console.WriteLine("Enter array number: ");
        line[0] = int.Parse(Console.ReadLine()); // set manually, because we do comparison with index i-1

        int longest = 1;
        int current = 1;
        string sequence = "";
        string temp = line[0] + ",";


        for (int i = 1; i < input; i++)
        {
            line[i] = int.Parse(Console.ReadLine());

            if (line[i - 1] < line[i])
            {
                current++;
                temp += line[i] + ",";

                if (current > longest) 
                {
                    longest = current;
                    sequence = temp;
                }
            }
            else 
            {
                current = 1;
                temp = line[i] + ",";
            }
        }
        Console.WriteLine(sequence.TrimEnd(','));
    }
}
