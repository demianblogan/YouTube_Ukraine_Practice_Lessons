#include <iostream>

int main()
{
	int distance = 0;

	std::cout << "Start distance: " << distance << '\n';
	distance += 17;
	std::cout << "distance after 1st day: " << distance << '\n';
	distance += 13;
	std::cout << "distance after 2nd day: " << distance << '\n';
	distance += 8;
	std::cout << "distance after 3rd day: " << distance << '\n';

	return 0;
}