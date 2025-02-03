#include <iostream>

int main()
{
	std::cout << "Enter your current time (hours & minutes): ";
	int hours, minutes;
	std::cin >> hours >> minutes;

	const int MINUTES_IN_HOUR = 60;
	int totalMinutes = hours * MINUTES_IN_HOUR + minutes;

	std::cout << hours << ":" << minutes << " = " << totalMinutes << " minutes.\n";

	return 0;
}