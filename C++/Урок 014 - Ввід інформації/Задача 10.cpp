#include <iostream>

int main()
{
	std::cout << "Enter a positive number: ";
	double number;
	std::cin >> number;

	double root = std::sqrt(number);

	std::cout << "Square root of your number is " << root << '\n';

	return 0;
}