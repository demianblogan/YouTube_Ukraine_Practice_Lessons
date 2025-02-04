#include <iostream>

int main()
{
	std::cout << "Enter your number: ";
	int number;
	std::cin >> number;

	std::cout << "If you see 1 - your number is not 2, 5, and 8.\n";
	std::cout << "If you see 0 - your number is 2, 5, or 8.\n";
	std::cout << (number != 2 && number != 5 && number != 8) << std::endl;

	return 0;
}