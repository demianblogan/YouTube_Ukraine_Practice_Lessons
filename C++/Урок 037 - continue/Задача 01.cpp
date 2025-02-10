#include <iostream>

int main()
{
	int computerNumber = 50;
	int userNumber;

	while (true)
	{
		std::cout << "Guess my number: ";
		std::cin >> userNumber;

		if (userNumber == computerNumber)
		{
			std::cout << "Right.\n";
			continue;
		}

		std::cout << "Wrong.\n";
	}

	return 0;
}