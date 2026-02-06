using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class StringClass
    {
        public void PracticeString()
        {
            Console.WriteLine("=== C# STRING EXAMPLES ===\n");

            string firstName = "Anik";
            string lastName = "Deb";
            int age = 23;

            // -------------------------
            // 1. STRING CONCATENATION
            // -------------------------
            string fullNameConcat = firstName + " " + lastName;
            Console.WriteLine("String Concatenation:");
            Console.WriteLine(fullNameConcat + "\n");

            // -------------------------
            // 2. STRING INTERPOLATION
            // -------------------------
            string fullNameInterpolated = $"{firstName} {lastName}"; //Syntax: $"{expression}"
            Console.WriteLine("String Interpolation:");
            Console.WriteLine($"Name: {fullNameInterpolated}, Age: {age}\n");

            // -------------------------
            // 3. VERBATIM STRING (@)
            // -------------------------
            string filePath = @"C:\Projects\CSharp\StringDemo\file.txt";
            Console.WriteLine("Verbatim String:");
            Console.WriteLine(filePath + "\n");

            // Verbatim string with multi-line text
            string multiLineText = @"Hello,
                                    This is a multi-line
                                    verbatim string in C#.";
            Console.WriteLine("Multi-line Verbatim String:");
            Console.WriteLine(multiLineText + "\n");

            // -------------------------
            // 4. ESCAPE SEQUENCES
            // -------------------------
            string escapedText = "Hello,\nWelcome to C#\tProgramming!";
            Console.WriteLine("Escape Sequences:");
            Console.WriteLine(escapedText + "\n");

            // -------------------------
            // 5. STRING LENGTH & METHODS
            // -------------------------
            Console.WriteLine("String Methods:");
            Console.WriteLine($"Length: {fullNameInterpolated.Length}");
            Console.WriteLine($"Upper: {fullNameInterpolated.ToUpper()}");
            Console.WriteLine($"Lower: {fullNameInterpolated.ToLower()}");
            Console.WriteLine($"Contains 'Anik': {fullNameInterpolated.Contains("Anik")}\n");

            // -------------------------
            // 6. STRING COMPARISON
            // -------------------------
            string a = "Hello";
            string b = "hello";

            Console.WriteLine("String Comparison:");
            Console.WriteLine($"Equals: {a.Equals(b)}");
            Console.WriteLine($"Equals (ignore case): {a.Equals(b, StringComparison.OrdinalIgnoreCase)}\n");

            // -------------------------
            // 7. INTERPOLATED VERBATIM STRING ($@)
            // -------------------------
            string projectName = "StringDemo";
            string configPath = $@"C:\Projects\CSharp\{projectName}\config.json";

            Console.WriteLine("Interpolated Verbatim String ($@):");
            Console.WriteLine(configPath + "\n");

            // -------------------------
            // 8. String Build in Methods
            // -------------------------

            string sample1 = "Hello";
            string sample2 = "World!";
            Console.WriteLine("string.Concat Method: "+ string.Concat(sample1, " ", sample2));
            string[] list = { "apple", "banana", "cherry" };
            string joinedString = string.Join(", ", list);
            Console.WriteLine("string.Join Method: "+ joinedString);
            Console.WriteLine("string.IndexOf Method: " + sample1.IndexOf("lo"));
            Console.WriteLine("string.Replace Method: " + sample2.Replace("World", "C#"));
            Console.WriteLine("string.Substring Method: " + sample1.Substring(1, 3));
            Console.WriteLine("string.Trim Method: " + "   padded string   ".Trim());
            Console.WriteLine("string.Split Method: " + string.Join(" | ", "one,two,three".Split(',')));
            Console.WriteLine("string.StartsWith Method: " + sample1.StartsWith("He"));
            Console.WriteLine("string.EndsWith Method: " +   sample1.EndsWith("lo"));
            Console.WriteLine("String.Insert Method: " + sample1.Insert(5, " C#"));

            string test = sample1; // Both test and sample1 reference the same string object in memory (i.e same reference)
            string newString = (string)sample1.Clone(); // Creates a new string that is a copy of the original string(e.g not same reference)
            string newString2 = new string(sample1.ToCharArray()); // Creates a new string that is a copy of the original string(e.g not same reference)

            Console.WriteLine("=== END OF DEMO ===");
        }
    }
}
