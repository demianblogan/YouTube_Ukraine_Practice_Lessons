#include <iostream>

int main()
{
	std::cout << "Enter your number: ";
	int number;
	std::cin >> number;

	const int LOWER_BOUND = -100;
	const int UPPER_BOUND = 100;

	std::cout << "If you see 1 - your number is in the range ";
	std::cout << "[" << LOWER_BOUND << " ... " << UPPER_BOUND << "] ";
	std::cout << "but not 2, 5, or 8.\n";

	std::cout << "If you see 0 - your number is not in the range ";
	std::cout << "[" << LOWER_BOUND << " ... " << UPPER_BOUND << "] \n";

	bool isInRange = (number >= LOWER_BOUND && number <= UPPER_BOUND);
	bool isNot2and5and8 = (number != 2 && number != 5 && number != 8);

	std::cout << (isInRange && isNot2and5and8) << std::endl;

	return 0;
}