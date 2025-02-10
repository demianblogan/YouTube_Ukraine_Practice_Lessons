#include <iostream>

int main()
{
	const int MINIMUM_HEIGHT = 3;
	int height; // number of rows
	bool isInputSuccessful = true;

	do
	{
		std::cout << "Enter height of rhombus (more than " << MINIMUM_HEIGHT << " and only odd): ";
		std::cin >> height;

		if (height < MINIMUM_HEIGHT)
		{
			std::cout << "Your number is less than " << MINIMUM_HEIGHT << ". Try again.\n";
			isInputSuccessful = false;
		}
		else if (height % 2 == 0)
		{
			std::cout << "Your number is even. Try again.\n";
			isInputSuccessful = false;
		}
		else
		{
			isInputSuccessful = true;
		}
	} while (!isInputSuccessful);

	int outerSpaces = height / 2;
	int innerSpaces = 0;
	for (int row = 0; row < height; row++)
	{
		// -------- Draw outer left spaces + asterisk --------
		for (int space = 0; space < outerSpaces; space++)
		{
			std::cout << ' ';
		}
		std::cout << "*";

		// -------- Draw inner spaces + asterisk --------
		if (innerSpaces > 0)
		{
			for (int space = 0; space < innerSpaces; space++)
			{
				std::cout << ' ';
			}
			std::cout << "*";
		}

		std::cout << std::endl;

		if (row < height / 2) // if it's first part of the rhombus
		{
			outerSpaces -= 1;

			if (row == 0)
			{
				innerSpaces += 1;
			}
			else
			{
				innerSpaces += 2;
			}
		}
		else // if it's second part of the rhombus
		{
			outerSpaces += 1;
			innerSpaces -= 2;
		}
	}

	return 0;
}