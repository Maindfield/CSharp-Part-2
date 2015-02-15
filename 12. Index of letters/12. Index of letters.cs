using System;

//Write a program that creates an array containing all letters from the alphabet (`A-Z`).
//Read a word from the console and print the index of each of its letters in the array.

class IndexOfLetters
{
    static void Main()
    {

        char[] line = new char[52];

        for (int i = 0; i < 26; i++)
        {
            line[i] = (char)(i + 65);
        }

        for (int i = 26; i < 52; i++)
        {
            line[i] = (char)(i + 97 - 26);
        }

        Console.Write("Enter word: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < line.Length; j++)
            {
                if (input[i] == line[j])
                {
                    Console.Write("[" + j + "]");
                }
            }
        }
        Console.WriteLine();
    }
}