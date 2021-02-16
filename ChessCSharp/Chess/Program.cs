using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int k = 0;
            Console.Write("Введите сторону клетки: ");//    std::cout << "Введите сторону клетки: ";
            string stringS = Console.ReadLine();//    std::cin >> s; Console.ReadLine(); - считывает ввод с клавиатуры и возвращает строку - string, string - тип данных переменной stringS
            s = Int32.Parse(stringS);//    std::cin >> s; Int32.Parse(stringS); - конвертация строки в число
            Console.Write("Введите количество клеток: ");//    std::cout << "Введите сторону клетки: ";
            string stringK = Console.ReadLine();
            k = Int32.Parse(stringK);


            //for (int i = 0; i < 256; i++)
            //{
            //    Console.WriteLine((char)i + "\t" + i);
            //}

            //int code = 83;
            //string s = code.ToString();
            //// char c1 = 'H';
            //char c2 = (char)code;
            //Console.WriteLine(c2); // S
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int b = 0; b < k; b++) //b - номер строки из клеток. Рисуем k строк из клеток.
            {
                for (int a = 0; a < s; a++) //в каждой строке из клеток рисуем s строчек из символов
                {
                    for (int i = 0; i < k; i++) //i - номер клетки слева-направо. В каждой строке рисуем k клеток
                    {
                        if ((i % 2 == 0 && b % 2 == 0) || (i % 2 == 1 && b % 2 == 1)) //если номер строки и номер клетки четный, или и номер строки и номер клетки нечетный, закрашиваем.
                        {
                            for (int j = 0; j < s; j++) //рисуем s символов
                            {
                                //Console.Write((char)178 + "" + (char)178);
                                // Console.Write('?' + "" + '?');
                                Console.Write("??");
                            }
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


            //Console.WriteLine('a' + "" + 'w');



        }
    }
}
