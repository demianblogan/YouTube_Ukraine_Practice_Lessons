#include <iostream>

int main()
{
	std::cout << "Enter your age: ";
	int age;
	std::cin >> age;

	const int DAYS_IN_YEAR = 365, HOURS_IN_DAY = 24, MINUTES_IN_HOUR = 60, SECONDS_IN_MINUTE = 60;
	int seconds = age * DAYS_IN_YEAR * HOURS_IN_DAY * MINUTES_IN_HOUR * SECONDS_IN_MINUTE;

	std::cout << "You've lived " << seconds << " seconds.\n";

	return 0;
}