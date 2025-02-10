#include <iostream>

int main()
{
	const int MIN = 1, MAX = 100;
	int divider = 7;

	for (int number = MIN; number <= MAX; number++)
	{
		if (number % divider != 0)
		{
			continue;
		}
		std::cout << number << "\t";
	}

	return 0;
}