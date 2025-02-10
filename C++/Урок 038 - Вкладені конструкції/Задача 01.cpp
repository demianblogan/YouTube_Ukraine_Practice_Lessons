#include <iostream>

int main()
{
	std::cout << "Enter character: ";
	char character;
	std::cin >> character;

	int rows;
	do
	{
		std::cout << "Enter number of rows: ";
		std::cin >> rows;

		if (rows <= 0)
		{
			std::cout << "Incorrect number. Try again.\n";
		}
	} while (rows <= 0);

	int columns;
	do
	{
		std::cout << "Enter number of columns: ";
		std::cin >> columns;

		if (columns <= 0)
		{
			std::cout << "Incorrect number. Try again.\n";
		}
	} while (columns <= 0);

	for (int row = 0; row < rows; row++)
	{
		for (int column = 0; column < columns; column++)
		{
			std::cout << character;
		}
		std::cout << std::endl;
	}

	return 0;
}