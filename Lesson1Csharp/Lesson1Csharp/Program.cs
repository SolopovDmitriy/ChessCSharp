using System;

namespace Lesson1Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] twoDRaggedArray = new int[SIZE][/*no need to input a value*/];
            for (int i = 0; i < SIZE; i++)
            {
                twoDRaggedArray[i] = new int[random.Next(0, SIZE)];
            }
            foreach (var itemi in twoDRaggedArray)
            {
                foreach (var item in itemi)
                {
                    //twoDRaggedArray[r][c] = random.Next(0, 10);
                    Console.WriteLine(twoDRaggedArray(random.Next(0, 10));
                }
                Console.WriteLine();
            }
        }
    }

}






