using System;

namespace ExtensionPractice3
{
    public static class Operations
    {
        public static void add(this int num,int b)
        {
            Console.WriteLine("Addition");
            int opr = num + b;
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Addition is : {opr}");
            Console.ForegroundColor = defaultColor;  
        }

        public static void sub(this int num, int b)
        {
            Console.WriteLine("Subtraction");
            int opr = num - b;
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Subtraction is : {opr}");
            Console.ForegroundColor = defaultColor;
        }
    }
}
