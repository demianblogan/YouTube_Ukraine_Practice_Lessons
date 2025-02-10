#include <iostream>

int main()
{
	const int MIN = 1, MAX = 9;

	for (int leftNumber = MIN; leftNumber <= MAX; leftNumber++)
	{
		for (int rightNumber = MIN; rightNumber <= MAX; rightNumber++)
		{
			int result = leftNumber * rightNumber;
			std::cout << leftNumber << " x " << rightNumber << " = " << result << std::endl;
		}
		std::cout << "--------------\n";
	}

	return 0;
}