#include <iostream>

int main()
{
	std::cout << "Enter two fraction numbers: ";
	double number1, number2;
	std::cin >> number1 >> number2;

	double sum = number1 + number2;
	std::cout << number1 << " + " << number2 << " = " << sum << '\n';

	return 0;
}