#include <iostream>

int main()
{
	const int JANUARY = 1;
	const int FEBRUARY = 2;
	const int MARCH = 3;
	const int APRIL = 4;
	const int MAY = 5;
	const int JUNE = 6;
	const int JULY = 7;
	const int AUGUST = 8;
	const int SEPTEMBER = 9;
	const int OCTOBER = 10;
	const int NOVEMBER = 11;
	const int DECEMBER = 12;

	std::cout << JANUARY << " - January \n";
	std::cout << FEBRUARY << " - February \n";
	std::cout << MARCH << " - March \n";
	std::cout << APRIL << " - April \n";
	std::cout << MAY << " - May \n";
	std::cout << JUNE << " - June \n";
	std::cout << JULY << " - July \n";
	std::cout << AUGUST << " - August \n";
	std::cout << SEPTEMBER << " - September \n";
	std::cout << OCTOBER << " - October \n";
	std::cout << NOVEMBER << " - November \n";
	std::cout << DECEMBER << " - December \n";

	std::cout << "Enter month: ";
	int month;
	std::cin >> month;

	int yearIsLeapAnswer;
	bool isYearLeap;
	
	switch (month)
	{
		// Months with 31 days:
	case JANUARY:
	case MARCH:
	case MAY:
	case JULY:
	case AUGUST:
	case OCTOBER:
	case DECEMBER:
		std::cout << "This month has 31 days\n";
		break;

		// Months with 30 days:
	case APRIL:
	case JUNE:
	case SEPTEMBER:
	case NOVEMBER:
		std::cout << "This month has 30 days\n";
		break;

		// Month with 28 days:
	case FEBRUARY:
		std::cout << "Is this year leap? (1 - yes, 0 - no): ";
		std::cin >> yearIsLeapAnswer;
		isYearLeap = (yearIsLeapAnswer == 1);
		std::cout << "This month has " << (isYearLeap ? 29 : 28) << " days\n";
		break;

	default:
		std::cout << "Incorrect input\n";
		break;
	}

    return 0;
}
