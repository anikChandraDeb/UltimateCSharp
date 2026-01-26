using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class ConditionalStatement
    {
        public void PracticeConditionalStatement()
        {
            Console.WriteLine("=== C# CONDITIONAL STATEMENTS DEMO ===\n");
            Console.WriteLine("Enter one Number: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            // -------------------------
            // 1. IF STATEMENT
            // -------------------------
            if (marks >= 40)
            {
                Console.WriteLine("If Statement:");
                Console.WriteLine("You have passed the exam.\n");
            }

            // -------------------------
            // 2. IF - ELSE STATEMENT
            // -------------------------
            if (marks >= 50)
            {
                Console.WriteLine("If-Else Statement:");
                Console.WriteLine("Result: Pass\n");
            }
            else
            {
                Console.WriteLine("Result: Fail\n");
            }

            // -------------------------
            // 3. IF - ELSE IF - ELSE
            // -------------------------
            Console.WriteLine("If-Else If-Else Statement:");
            if (marks >= 80)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                Console.WriteLine("Grade: C");
            }
            Console.WriteLine();

            // -------------------------
            // 4. NESTED IF
            // -------------------------
            int age = 22;
            bool hasIdCard = true;

            Console.WriteLine("Nested If Statement:");
            if (age >= 18)
            {
                if (hasIdCard)
                {
                    Console.WriteLine("You are allowed to enter.\n");
                }
                else
                {
                    Console.WriteLine("ID Card is required.\n");
                }
            }
            else
            {
                Console.WriteLine("Age must be 18 or above.\n");
            }

            // -------------------------
            // 5. SWITCH STATEMENT
            // -------------------------
            int day = 5;

            Console.WriteLine("Switch Statement:");
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // -------------------------
            // 6. Modern SWITCH Expression(C# 8+) -> Mainly works by matching pattern
            // -------------------------

            string grade = marks switch
            {
                >= 80 => "A+", //all type of relational operator(>,<,>=,<=), equality, logical and/or, range matching, type pattern
                >= 70 => "A",
                >= 60 => "B",
                <=59 and >=50 => "C", //Range Matching
                -1 => "-1", //Equality
                _ => "Fail"
            };

            Console.WriteLine($"Grade: {grade}");

            // -------------------------
            // 7. Modern SWITCH with when(C# 7+)
            // -------------------------

            switch (marks)
            {
                case int m when m >= 80:
                    Console.WriteLine("A+");
                    break;

                case int m when m >= 70:
                    Console.WriteLine("A");
                    break;

                case int m when m >= 60:
                    Console.WriteLine("B");
                    break;

                default:
                    Console.WriteLine("Fail");
                    break;
            }

            // -------------------------
            // 8. Goto Statement(Not used in real project)
            // -------------------------

            int number = 1;

            start:   // label
            Console.WriteLine($"Number: {number}");
            number++;

            if (number <= 3)
            {
                goto start;   // jump to label
            }

            Console.WriteLine("\n=== END OF DEMO ===");
        }
    }
}
