#include <iostream>

int main()
{
	std::cout << "Enter 2-digit number: ";
	int number;
	std::cin >> number;

	int digit1 = number / 10;
	int digit2 = number % 10;

	std::cout << "Your number's digits: " << digit1 << " and " << digit2 << '\n';

	return 0;
}