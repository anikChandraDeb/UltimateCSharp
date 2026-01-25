using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Operator
    {
        public void OperatorPractice()
        {
            Console.WriteLine("=== C# OPERATORS DEMO ===\n");

            // -------------------------
            // 1. ARITHMETICAL OPERATORS
            // -------------------------
            int a = 10;
            int b = 3;

            Console.WriteLine("Arithmetical Operators:");
            Console.WriteLine($"Addition (a + b): {a + b}");
            Console.WriteLine($"Subtraction (a - b): {a - b}");
            Console.WriteLine($"Multiplication (a * b): {a * b}");
            Console.WriteLine($"Division (a / b): {a / b}");
            Console.WriteLine($"Modulus (a % b): {a % b}\n");

            // -------------------------
            // 2. ASSIGNMENT OPERATORS
            // -------------------------
            int x = 5;
            x += 2;   // x = x + 2
            x -= 1;   // x = x - 1
            x *= 3;   // x = x * 3
            x /= 2;   // x = x / 2
            x %= 2;   // x = x % 2

            Console.WriteLine("Assignment Operators:");
            Console.WriteLine($"Final value of x: {x}\n");

            // -------------------------
            // 3. INCREMENT & DECREMENT
            // -------------------------
            int count = 5;

            Console.WriteLine("Increment & Decrement Operators:");
            Console.WriteLine($"Post-increment (count++): {count++}");
            Console.WriteLine($"After post-increment: {count}");
            Console.WriteLine($"Pre-increment (++count): {++count}");
            Console.WriteLine($"Post-decrement (count--): {count--}");
            Console.WriteLine($"Pre-decrement (--count): {--count}\n");

            // -------------------------
            // 4. COMPARISON OPERATORS
            // -------------------------
            int p = 10;
            int q = 20;

            Console.WriteLine("Comparison Operators:");
            Console.WriteLine($"p == q: {p == q}");
            Console.WriteLine($"p != q: {p != q}");
            Console.WriteLine($"p > q: {p > q}");
            Console.WriteLine($"p < q: {p < q}");
            Console.WriteLine($"p >= q: {p >= q}");
            Console.WriteLine($"p <= q: {p <= q}\n");

            // -------------------------
            // 5. LOGICAL and Conditional OPERATORS 
            // -------------------------
            bool isLoggedIn = true;
            bool isAdmin = false;

            Console.WriteLine("Logical Operators:");
            Console.WriteLine($"Logical AND (isLoggedIn && isAdmin): {isLoggedIn && isAdmin}"); //Check both side even if left side false
            Console.WriteLine($"Conditional AND (isLoggedIn && isAdmin): {isLoggedIn && isAdmin}"); //If left side false don't check right side
            Console.WriteLine($"Logical OR (isLoggedIn || isAdmin): {isLoggedIn || isAdmin}");
            Console.WriteLine($"Conditional OR (isLoggedIn || isAdmin): {isLoggedIn || isAdmin}");
            Console.WriteLine($"NOT (!isLoggedIn): {!isLoggedIn}\n");

            // -------------------------
            // 6. CONCATENATION OPERATOR
            // -------------------------
            string firstName = "Anik";
            string lastName = "Deb";

            string fullName = firstName + lastName;
            string result1 = "Test" + 5;
            string result2 = 5 + "Test";

            Console.WriteLine("Concatenation Operator:");
            Console.WriteLine($"Full Name: {fullName}\n");
            Console.WriteLine("Result1 ", result1, " Result2: ", result2 );


            // -------------------------
            // 7. TERNARY OPERATOR
            // -------------------------
            int age = 20;
            string result = age >= 18 ? "Adult" : "Minor";

            Console.WriteLine("Ternary Operator:");
            Console.WriteLine($"Age: {age} => {result}\n");

            // -------------------------
            // 7. Bitwise OPERATOR
            // -------------------------
            int operand1 = 10;
            int operand2 = 20;
            Console.WriteLine("---- Bitwise Opertaor ----");
            Console.WriteLine("Bitwise/Binary And(&): "+ (operand1 & operand2));
            Console.WriteLine("Bitwise/Binary Or(|): " + ( operand1 | operand2));
            Console.WriteLine("Bitwise/Binary Xor(^): " + (operand1 ^ operand2));
            Console.WriteLine("Bitwise/Binary Complement(~): "+ ~operand1);
            Console.WriteLine("Bitwise/Binary Left(<<): "+ (operand1 << 2));
            Console.WriteLine("Bitwise/Binary Right(>>): " + (operand1 >> 2));

            Console.WriteLine("=== END OF DEMO ===");
        }
    }
}
