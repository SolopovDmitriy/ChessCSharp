#include<iostream>
void main()
{
	setlocale(LC_ALL, "Rus");
	int s = 0;
	int k = 0;
	std::cout << "������� ������� ������: ";
	std::cin >> s;
	std::cout << "������� ���������� ������: ";
	std::cin >> k;
	for (int i = 0; i < 256;i++)
		std::cout << (char)i << "/t" << i << std::endl;
	for (int b = 0; b < k;b++) //b - ����� ������ �� ������. ������ k ����� �� ������.
	{
		for (int a = 0; a < s; a++) //� ������ ������ �� ������ ������ s ������� �� ��������
		{
			for (int i = 0;i < k;i++) //i - ����� ������ �����-�������. � ������ ������ ������ k ������
			{
				if ((i % 2 == 0 && b % 2 == 0) || (i % 2 == 1 && b % 2 == 1)) //���� ����� ������ � ����� ������ ������, ��� � ����� ������ � ����� ������ ��������, �����������.
				{
					for (int j = 0;j < s;j++) //������ s ��������
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