using System;

//Write a program that reads two integer numbers N and K 
//and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

class MaximalKSum
{
    static void Main()
    {

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] line = new int[n];

        for (int i = 0; i < line.Length; i++)
        {
            Console.Write("Enter array number: ");
            line[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(line);

        int result = 0;
        for (int i = line.Length - 1; i > line.Length - 1 - k; i--)
        {
            result += line[i];
            Console.Write(line[i]);

            if (i == line.Length - k)
            {
                Console.Write(" = ");
            }
            else
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine(result);
    }
}

