#include <iostream>

int main()
{
	std::cout << "Enter a number: ";
	int number;
	std::cin >> number;

	int digits = 1;

	if (number != 0)
	{
		for (; number / 10 != 0; number /= 10)
		{
			digits++;
		}
	}

	std::cout << "Digits: " << digits << std::endl;

	return 0;
}