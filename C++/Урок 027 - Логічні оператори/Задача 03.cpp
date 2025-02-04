#include <iostream>

int main()
{
	std::cout << "Enter your number: ";
	int number;
	std::cin >> number;

	std::cout << "If you see 1 - your number is 1, 2, or 3.\\n";
	std::cout << "If you see 0 - your number is not 1, 2, and 3.\\n";
	std::cout << (number == 1 || number == 2 || number == 3) << std::endl;

	return 0;
}