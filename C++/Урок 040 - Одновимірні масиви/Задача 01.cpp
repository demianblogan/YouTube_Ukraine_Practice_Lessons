#include <iostream>

int main()
{
	const unsigned int SIZE = 5;
	int numbers[SIZE] = { 5, 10, 15, 20, 25 };

	for (unsigned int i = 0; i < SIZE; i++)
	{
		std::cout << numbers[i] << " ";
	}

	return 0;
}