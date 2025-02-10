#include <iostream>

int main()
{
	std::cout << "How many iterations do you want?: ";
	int iterations;
	std::cin >> iterations;

	for (int i = 0; i < iterations; i++)
	{
		std::cout << "Iteration #: " << i << std::endl;
	}

	return 0;
}