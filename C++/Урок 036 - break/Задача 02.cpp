#include <iostream>

int main()
{
	const int MIN_VALUE = 2, MAX_VALUE = 10;
	int number;
	for (number = MIN_VALUE; number <= MAX_VALUE; number++)
	{
		// Ask user the question:
		std::cout << "Is number " << number << " simple? (y - yes, n - no): ";
		char userAnswer;
		std::cin >> userAnswer;

		// Check whether the number is simple:
		bool isNumberSimple = true;
		for (int divider = 2; divider < number; divider++)
		{
			if (number % divider == 0)
			{
				isNumberSimple = false;
				break;
			}
		}

		// Check user answer with the result:
		if ((userAnswer == 'y' && isNumberSimple) || (userAnswer == 'n' && !isNumberSimple))
		{
			std::cout << "You're right.";
			if (number < MAX_VALUE)
			{
				std::cout << " Let's go to the next number...\n";
			}
		}
		else
		{
			std::cout << "You're wrong.\n";
			break;
		}
	}

	return 0;
}