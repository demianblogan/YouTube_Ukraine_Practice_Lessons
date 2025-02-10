#include <iostream>

int main()
{
	// ------ Input height of rhombus ------
	const int MIN_HEIGHT = 3, MAX_HEIGHT = 9;
	int height; // number of rows
	bool isInputSuccessful = true;

	do
	{
		std::cout << "Enter height of rhombus ";
		std::cout << "(in diapason [" << MIN_HEIGHT << "..." << MAX_HEIGHT << "] and only odd) : ";
		std::cin >> height;

		if (height < MIN_HEIGHT || height > MAX_HEIGHT)
		{
			std::cout << "Your number is not in the diapason. Try again.\n";
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

	// ----- Input number of rhombuses -----
	const int MAX_RHOMBUSES_AMOUNT = 6;
	int rhombuses;
	do
	{
		std::cout << "Enter number of rhombuses (up to " << MAX_RHOMBUSES_AMOUNT << "): ";
		std::cin >> rhombuses;

		if (rhombuses <= 0 || rhombuses > MAX_RHOMBUSES_AMOUNT)
		{
			std::cout << "Incorrect number. Try again.\n";
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
		for (int rhombus = 0; rhombus < rhombuses; rhombus++)
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

			// -------- Draw outer right spaces + space between rhombuses --------
			for (int space = 0; space < outerSpaces; space++)
			{
				std::cout << ' ';
			}
			std::cout << " ";
		}

		std::cout << std::endl;

		if (row < height / 2) // if it's the first part of the rhombus
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
		else // if it's the second part of the rhombus
		{
			outerSpaces += 1;
			innerSpaces -= 2;
		}
	}

	return 0;
}