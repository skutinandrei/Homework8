using System.Diagnostics;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive method:");
            ShowFiobonacciNumber(5, FindFiobonacciNumberRecursive);
            ShowFiobonacciNumber(10, FindFiobonacciNumberRecursive);
            ShowFiobonacciNumber(20, FindFiobonacciNumberRecursive);

            Console.WriteLine("\nLoop method:");
            ShowFiobonacciNumber(5, FindFiobonacciNumberLoop);
            ShowFiobonacciNumber(10, FindFiobonacciNumberLoop);
            ShowFiobonacciNumber(20, FindFiobonacciNumberLoop);
        }

        static int FindFiobonacciNumberRecursive(int n)
        {
            if (n == 0) { return 0; }
            if (n == 1) { return 1; }
            return FindFiobonacciNumberRecursive(n - 1) + FindFiobonacciNumberRecursive(n - 2);
        }

        static int FindFiobonacciNumberLoop(int n)
        {
            if (n == 0) { return 0; }
            if (n == 1) { return 1; }

            int num0 = 0;
            int num1 = 1;

            for (int i = 2; i <= n; i++)
            {
                int num2 = num0 + num1;

                num0 = num1;
                num1 = num2;
            }

            return num1;
        }

        static void ShowFiobonacciNumber(int n, Func<int, int> operation)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var result = operation(n);
            stopWatch.Stop();
            var time = stopWatch.Elapsed.Microseconds;

            Console.WriteLine($"{n}th Fiobonacci number = {result}. RunTime measurement: {time} microseconds.");
        }
    }
}
