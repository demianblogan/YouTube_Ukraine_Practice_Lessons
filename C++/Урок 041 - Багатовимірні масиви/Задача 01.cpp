#include <iostream>

int main()
{
	const unsigned int ROWS = 3, COLUMNS = 4;
	int array[ROWS][COLUMNS] =
	{
		{ 10, 20, 30, 40 },
		{ 50, 60, 70, 80 },
		{ 11, 12, 13, 14 }
	};

	for (unsigned int i = 0; i < ROWS; i++)
	{
		for (unsigned int j = 0; j < COLUMNS; j++)
		{
			std::cout << array[i][j] << "\t";
		}
		std::cout << std::endl;
	}

	return 0;
}