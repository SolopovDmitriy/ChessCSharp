#include<iostream>
void main()
{
	setlocale(LC_ALL, "Rus");
	int s = 0;
	int k = 0;
	std::cout << "Введите сторону клетки: ";
	std::cin >> s;
	std::cout << "Введите количество клеток: ";
	std::cin >> k;
	for (int i = 0; i < 256;i++)
		std::cout << (char)i << "/t" << i << std::endl;
	for (int b = 0; b < k;b++) //b - номер строки из клеток. Рисуем k строк из клеток.
	{
		for (int a = 0; a < s; a++) //в каждой строке из клеток рисуем s строчек из символов
		{
			for (int i = 0;i < k;i++) //i - номер клетки слева-направо. В каждой строке рисуем k клеток
			{
				if ((i % 2 == 0 && b % 2 == 0) || (i % 2 == 1 && b % 2 == 1)) //если номер строки и номер клетки четный, или и номер строки и номер клетки нечетный, закрашиваем.
				{
					for (int j = 0;j < s;j++) //рисуем s символов
						std::cout << (char)178 << (char)178;
				}
				else
				{
					for (int j = 0; j < s; j++)
						std::cout << "  ";
				}
			}
			std::cout << std::endl;
		}
	}



	system("pause");
}