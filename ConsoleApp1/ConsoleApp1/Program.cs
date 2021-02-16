using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int SIZE = 20;
            int[,] twoDMatrix = new int[SIZE, SIZE];
            //Console.WriteLine(twoDMatrix.Length);
            Random random = new Random();
            for (int r = 0; r < SIZE; r++)
            {​​​​​​
                    for (int c = 0; c < SIZE; c++)
                {​​​​​​
                        twoDMatrix[r, c] = random.Next(0, 10);
                    Console.Write(twoDMatrix[r, c] + " ");
                }​​​​​​
                    Console.WriteLine();
            }​​​​​​
                Console.WriteLine();
            //ragged array
            int[][] twoDRaggedArray = new int[SIZE][/*no need to input a value*/];
            for (int i = 0; i < SIZE; i++)
            {​​​​​​
                    twoDRaggedArray[i] = new int[random.Next(0, SIZE)];
            }​​​​​​
                for (int r = 0; r < twoDRaggedArray.Length; r++)
            {​​​​​​
                    for (int c = 0; c < twoDRaggedArray[r].Length; c++)
                {​​​​​​
                        twoDRaggedArray[r][c] = random.Next(0, 10);
                    Console.Write(twoDRaggedArray[r][c] + " ");
                }​​​​​​
                    Console.WriteLine();
            }​​​​​​

            //    int SIZE = 10;

            //    Random random = new Random ();
            //    Console.WriteLine("Hello World!");
            //    int[][] twoDRaggedArray = new int[SIZE][/*no need to input a value*/];

            //    for (int i = 0; i < SIZE; i++)
            //    {
            //        twoDRaggedArray[i] = new int[random.Next(0, SIZE)];
            //    }

            //    for (int r = 0; r < twoDRaggedArray.Length; r++)
            //    {

            //        for (int c = 0; c < twoDRaggedArray[r].Length; c++)
            //        {
            //            twoDRaggedArray[r][c] = random.Next(0, 10);
            //        }
            //    }

            //    foreach (var row in twoDRaggedArray)
            //    {
            //        foreach (var cell in row)
            //        {

            //            Console.Write(cell + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    for (int i = 0; i < 10; i++)
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            Console.Write("{0}\t", [i, j]);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.ReadKey();
            //}
            int s = 0;
            int k = 0;

            Console.Write("Введите сторону клетки: ");
            string stringS = Console.ReadLine();
            s = Int32.Parse(stringS);
            Console.Write("Введите количество клеток: ");
            string stringK = Console.ReadLine();
            k = Int32.Parse(stringK);
            // std::cin >> k;
            for (int i = 0; i < 256; i++)
                Console.WriteLine("" + (char)i + "/t" + i);
            for (int b = 0; b < k; b++) //b - номер строки из клеток. Рисуем k строк из клеток.
            {
                for (int a = 0; a < s; a++) //в каждой строке из клеток рисуем s строчек из символов
                {
                    for (int i = 0; i < k; i++) //i - номер клетки слева-направо. В каждой строке рисуем k клеток
                    {
                        if ((i % 2 == 0 && b % 2 == 0) || (i % 2 == 1 && b % 2 == 1)) //если номер строки и номер клетки четный, или и номер строки и номер клетки нечетный, закрашиваем.
                        {
                            for (int j = 0; j < s; j++) //рисуем s символов
                                Console.Write((char)178 << (char)178);
                        }
                        else
                        {
                            for (int j = 0; j < s; j++)
                                Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
            }



            //system("pause");
        }

    }
}


//#include<iostream>
//void main()
//{
//    setlocale(LC_ALL, "Rus");
//    int s = 0;
//    int k = 0;
//    std::cout << "Введите сторону клетки: ";
//    std::cin >> s;
//    std::cout << "Введите количество клеток: ";
//    std::cin >> k;
//    for (int i = 0; i < 256; i++)
//        std::cout << (char)i << "/t" << i << std::endl;
//    for (int b = 0; b < k; b++) //b - номер строки из клеток. Рисуем k строк из клеток.
//    {
//        for (int a = 0; a < s; a++) //в каждой строке из клеток рисуем s строчек из символов
//        {
//            for (int i = 0; i < k; i++) //i - номер клетки слева-направо. В каждой строке рисуем k клеток
//            {
//                if ((i % 2 == 0 && b % 2 == 0) || (i % 2 == 1 && b % 2 == 1)) //если номер строки и номер клетки четный, или и номер строки и номер клетки нечетный, закрашиваем.
//                {
//                    for (int j = 0; j < s; j++) //рисуем s символов
//                        std::cout << (char)178 << (char)178;
//                }
//                else
//                {
//                    for (int j = 0; j < s; j++)
//                        std::cout << "  ";
//                }
//            }
//            std::cout << std::endl;
//        }
//    }



//    system("pause");
//}