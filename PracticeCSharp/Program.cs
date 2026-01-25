using CSharpBasics;

namespace PracticeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CSharp Basics 
            var firstProgram = new FirstProgram();
            firstProgram.Print();

            var consoleClass = new ConsoleClass();
            consoleClass.PracticeConsole();

            var variable = new Variable();
            variable.VariablePractice();

            var op = new Operator();
            op.OperatorPractice();
        }
    }
}
