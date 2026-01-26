using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Loops
    {
        public void PracticeLoops()
        {
            Console.WriteLine("=== C# LOOPS DEMO ===\n");

            // -------------------------
            // 1. FOR LOOP
            // -------------------------
            Console.WriteLine("For Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"i = {i}");
            }
            Console.WriteLine();

            // -------------------------
            // 2. WHILE LOOP
            // -------------------------
            Console.WriteLine("While Loop:");
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine($"count = {count}");
                count++;
            }
            Console.WriteLine();

            // -------------------------
            // 3. DO-WHILE LOOP
            // -------------------------
            Console.WriteLine("Do-While Loop:");
            int number = 1;
            do
            {
                Console.WriteLine($"number = {number}");
                number++;
            } while (number <= 5);
            Console.WriteLine();

            // -------------------------
            // 4. FOREACH LOOP
            // -------------------------
            Console.WriteLine("Foreach Loop:");
            int[] numbers = { 10, 20, 30, 40, 50 };

            foreach (int n in numbers)
            {
                Console.WriteLine($"value = {n}");
            }
            Console.WriteLine();

            // -------------------------
            // 5. NESTED LOOP
            // -------------------------
            Console.WriteLine("Nested Loop:");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }
            Console.WriteLine();

            // -------------------------
            // 6. Loop Control Statement(break and continue)
            // -------------------------
            Console.WriteLine("Infinite Loop (controlled with break):");
            int x = 1;
            while (true)
            {
                Console.WriteLine($"x = {x}");
                x++;

                if (x > 3)
                    break; //Stop the loop iteration
            }

            Console.WriteLine("Ignore even number");
            int xx = 1;
            for(int i = 1; i <= xx; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("\n=== END OF DEMO ===");
        }
    }
}
