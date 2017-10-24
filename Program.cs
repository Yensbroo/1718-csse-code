using System;

namespace oefening02
{
    class Program
    {
        static void Main(string[] args)
        {
            uitvoerenFibonacci();
        }
        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for(int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        private static void uitvoerenFibonacci()
        {
            int input;
            Console.WriteLine("Geef een getal in");
            input = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < input; i ++) 
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
