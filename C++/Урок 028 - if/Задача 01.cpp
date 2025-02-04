#include <iostream>

int main()
{
	std::cout << "Enter a number: ";
	int number;
	std::cin >> number;

	if (number > 0)
	{
		std::cout << "Your number is greater than 0\n";
	}

	return 0;
}