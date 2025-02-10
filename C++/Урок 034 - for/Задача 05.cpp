#include <iostream>

int main()
{
	std::cout << "Enter a number: ";
	double number;
	std::cin >> number;

	std::cout << "Enter an exponent: ";
	int exponent;
	std::cin >> exponent;

	double power;

	if (number == 0 && exponent < 0)
	{
		std::cout << "Impossible to calculate\n";
	}
	else
	{
		if (exponent == 0)
		{
			power = 1;
		}
		else if (exponent > 0)
		{
			power = 1;
			for (int i = 0; i < exponent; i++)
			{
				power *= number;
			}
		}
		else if (exponent < 0)
		{
			exponent = -exponent;
			power = 1;
			for (int i = 0; i < exponent; i++)
			{
				power *= number;
			}
			power = 1.0 / power;
		}

		std::cout << "(" << number << ")^(" << exponent << ") = " << power << std::endl;
	}

	return 0;
}