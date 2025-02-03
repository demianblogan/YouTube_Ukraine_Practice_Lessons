#include <iostream>

int main()
{
	std::cout << "Enter a number: ";
	int number;
	std::cin >> number;

	int square = number * number;
	std::cout << number << "^2 = " << square << '\n';

	return 0;
}