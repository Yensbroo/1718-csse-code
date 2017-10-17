using System;
using System.Collections.Generic;

namespace opdrachtweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, i;
            Console.WriteLine("enter a value:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for(i = 0; i <= 10; i++)
            {
                int result = firstNumber * i;
               Console.WriteLine("{0} * {1} = {2}", i, firstNumber, result);
            }
        }
    }
}
