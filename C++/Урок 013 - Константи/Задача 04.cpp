#include <iostream>

int main()
{
	const int DAYS_IN_YEAR = 365;
	const int HOURS_IN_DAY = 24;
	const int MINUTES_IN_HOUR = 60;
	const int SECONDS_IN_MINUTE = 60;

	int years = 10;
	int days = years * DAYS_IN_YEAR;
	int hours = days * HOURS_IN_DAY;
	int minutes = hours * MINUTES_IN_HOUR;
	int seconds = minutes * SECONDS_IN_MINUTE;

	std::cout << years << " years = ";
	std::cout << days << " days = ";
	std::cout << hours << " hours = ";
	std::cout << minutes << " minutes = ";
	std::cout << seconds << " seconds.\n";

	return 0;
}