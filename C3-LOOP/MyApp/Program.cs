using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Call the Add method and print the result
            ForLoopExample();
            WhileLoopExample();
            DoWhileLoopExample();
            ForEachLoopExample();
        }
        // 1.Method For Loop
        static void ForLoopExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        // 2.Method While Loop
        static void WhileLoopExample()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        // 3.Method Do While Loop
        static void DoWhileLoopExample()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
        }
        // 4.Method For Each Loop
        static void ForEachLoopExample()
        {
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

