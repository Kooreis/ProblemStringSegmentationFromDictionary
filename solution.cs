Here is a simple console application in C# that solves the problem:

```C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> dictionary = new List<string> { "apple", "pen", "applepen", "pine", "pineapple" };
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.WriteLine(CanBeSegmented(input, dictionary));
    }

    static bool CanBeSegmented(string input, List<string> dictionary)
    {
        int[] pos = new int[input.Length + 1];

        pos[0] = -1;

        for (int i = 0; i < input.Length; i++)
        {
            if (pos[i] != -1)
            {
                for (int j = i + 1; j <= input.Length; j++)
                {
                    string str = input.Substring(i, j - i);
                    if (dictionary.Contains(str))
                    {
                        pos[j] = i;
                    }
                }
            }
        }

        return pos[input.Length] != -1;
    }
}
```

This console application first asks the user to input a string. It then checks if this string can be segmented into words from a predefined dictionary. The dictionary is a list of strings that contains the words "apple", "pen", "applepen", "pine", and "pineapple". The function `CanBeSegmented` checks if the input string can be segmented into words from this dictionary. If it can, the function returns `true`; otherwise, it returns `false`. The result is then printed to the console.