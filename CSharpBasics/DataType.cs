using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class DataType
    {
        public void PracticeDataType()
        {
            Console.WriteLine("=== C# Primitive DATA TYPES DEMO ===\n");

            // -------------------------
            // 1. VALUE TYPES
            // -------------------------

            // Integer types
            byte b = 255;
            sbyte sb = -128;
            short s = -32000;
            ushort us = 65000;
            int i = 100;
            uint ui = 200;
            long l = 1234567890;
            ulong ul = 9876543210;

            // Floating point types
            float f = 3.14f;
            double d = 3.141592653;
            decimal dec = 99.99m;

            // Other value types
            char c = 'A';
            bool isActive = true;

            Console.WriteLine("Value Types:");
            Console.WriteLine($"byte: {b}, int: {i}, long: {l}");
            Console.WriteLine($"float: {f}, double: {d}, decimal: {dec}");
            Console.WriteLine($"char: {c}, bool: {isActive}\n");
            Console.WriteLine("Default value: ", default(byte));
        }
    }
}
