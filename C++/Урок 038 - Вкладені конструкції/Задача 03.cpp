#include <iostream>

int main()
{
	int min, max;
	do
	{
		std::cout << "Enter two numbers, min & max: ";
		std::cin >> min >> max;

		if (min < 2)
		{
			std::cout << "Min is less than 2. Try again.\n";
		}
	} while (min < 2);

	if (min > max)
	{
		int temp = min;
		min = max;
		max = temp;
	}

	std::cout << "All simple numbers between " << min << " and " << max << ":\n";
	for (int number = min; number <= max; number++)
	{
		bool isNumberSimple = true;

		for (int divider = 2; divider < number; divider++)
		{
			if (number % divider == 0)
			{
				isNumberSimple = false;
				break;
			}
		}

		if (isNumberSimple)
		{
			std::cout << number << "\t";
		}
	}

	return 0;
}