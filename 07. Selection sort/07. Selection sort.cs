using System;
using System.Linq;
class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter array length:");
        int n = int.Parse(Console.ReadLine());
        int[] line = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter array number: ");
            line[i] = int.Parse(Console.ReadLine());
        }

        line = Selection(line);
        Console.WriteLine(string.Join(", ", line));
    }
    private static int[] Selection(int[] unsorted)
    {
        int[] sortedNumbers = new int[unsorted.Length];
        for (int i = 0; i < sortedNumbers.Length; i++)
        {
            int sortedIndex = Array.IndexOf(unsorted, unsorted.Min());
            sortedNumbers[i] = unsorted[sortedIndex];
            unsorted[sortedIndex] = int.MaxValue;
        }
        return sortedNumbers;
    }
}
