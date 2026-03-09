using CSharpBasics;
using CSharpOOP;

namespace PracticeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CSharp Basics 
            //var firstProgram = new FirstProgram();
            //firstProgram.Print();

            //var consoleClass = new ConsoleClass();
            //consoleClass.PracticeConsole();

            //var variable = new Variable();
            //variable.VariablePractice();

            //var op = new Operator();
            //op.OperatorPractice();

            //var conditional = new ConditionalStatement();
            //conditional.PracticeConditionalStatement();

            var practiceString = new StringClass();
            practiceString.PracticeString();

            var product1 = new Product();
            var product2 = new Product();
            product1.Id = 1;
            product1.Name = "Laptop";
            product1.Price = 999.99m;
            product1.Sku = "LAP123";
            product1.Stock = 10;
            product2.Id = 2;
            product2.Name = "Smartphone";
            product2.Price = 499.99m;
            product2.Sku = "SMP456";

            Console.WriteLine($"Product 1: {product1.Name}, Price: {product1.Price}, Stock: {product1.Stock}");     
            Console.WriteLine($"Product 2: {product2.Name}, Price: {product2.Price}, Stock: {product2.Stock}");
        }
    }
}
