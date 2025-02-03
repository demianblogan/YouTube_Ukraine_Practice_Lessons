#include <iostream>

int main()
{
	// Ввід дробових чисел:
	std::cout << "Enter two fraction numbers: ";
	double number1, number2;
	std::cin >> number1 >> number2;

	// Обрахунок суми:
	double sum = number1 + number2;

	// Вивід результату додавання на екран:
	std::cout << number1 << " + " << number2 << " = " << sum << '\n';

	return 0;
}