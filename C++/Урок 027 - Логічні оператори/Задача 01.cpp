#include <iostream>

int main()
{
	std::cout << "Enter your number: ";
	int number;
	std::cin >> number;

	const int LOWER_BOUND = -100;
	const int UPPER_BOUND = 100;

	std::cout << "If you see 1 - your number is in the range ";
	std::cout << "[" << LOWER_BOUND << " ... " << UPPER_BOUND << "] \\n";
	std::cout << "If you see 0 - your number is not in the range ";
	std::cout << "[" << LOWER_BOUND << " ... " << UPPER_BOUND << "] \\n";

	std::cout << (number >= LOWER_BOUND && number <= UPPER_BOUND) << std::endl;

	return 0;
}