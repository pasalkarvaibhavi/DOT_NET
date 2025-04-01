using System;
using System.Globalization;
using System.Linq;
using System.Text;

public class StringManipulationDemo
{
    

    public static string CapitalizeWords(string input)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return string.Join(" ", input.Split(' ').Select(word => textInfo.ToTitleCase(word.ToLower())));
    }

    public static string RemoveVowels(string input)
    {
        string vowels = "aeiouAEIOU";
        StringBuilder result = new StringBuilder();
        foreach (char c in input)
        {
            if (!vowels.Contains(c))
                result.Append(c);
        }
        return result.ToString();
    }
    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string trimmed = input.Trim();
        string upper = trimmed.ToUpper();
        string lower = trimmed.ToLower();
        string substring = trimmed.Length >= 5 ? trimmed.Substring(0, 5) : trimmed;
        string replaced = trimmed.Replace("World", "Universe");
        string noVowels = RemoveVowels(trimmed);
        string capitalized = CapitalizeWords(trimmed);

        Console.WriteLine("\n--- String Transformations ---");
        Console.WriteLine("\nTrimmed: " + trimmed);
        Console.WriteLine("\nUppercase: " + upper);
        Console.WriteLine("\nLowercase: " + lower);
        Console.WriteLine("\nSubstring (first 5 characters): " + substring);
        Console.WriteLine("\nReplaced (\"World\" -> \"Universe\"): " + replaced);
        Console.WriteLine("\nWithout Vowels: " + noVowels);
        Console.WriteLine("\nCapitalized: " + capitalized);

        Console.Write("\nCharacters: ");
        for (int i = 0; i < trimmed.Length; i++)
        {
            Console.Write(trimmed[i] + " ");
        }
        Console.WriteLine();

    }
}

/*
 Output:
Enter a string:
Hi, This is Vaibhavi Pasalkar from Fergusson College!

--- String Transformations ---

Trimmed: Hi, This is Vaibhavi Pasalkar from Fergusson College!

Uppercase: HI, THIS IS VAIBHAVI PASALKAR FROM FERGUSSON COLLEGE!

Lowercase: hi, this is vaibhavi pasalkar from fergusson college!

Substring (first 5 characters): Hi, T

Replaced ("World" -> "Universe"): Hi, This is Vaibhavi Pasalkar from Fergusson College!

Without Vowels: H, Ths s Vbhv Pslkr frm Frgssn Cllg!

Capitalized: Hi, This Is Vaibhavi Pasalkar From Fergusson College!
Characters: H i ,   T h i s   i s   V a i b h a v i   P a s a l k a r   f r o m   F e r g u s s o n   C o l l e g e !

*/