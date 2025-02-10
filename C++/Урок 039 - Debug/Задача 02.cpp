#include <iostream>

int main()
{
	int rows = 5;
	for (int row = 0; row < rows; row++)
	{
		for (int column = 0; column < row; column++)
		{
			std::cout << '*';
		}
		std::cout << std::endl;
	}
	return 0;
}