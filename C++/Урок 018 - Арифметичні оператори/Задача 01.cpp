#include <iostream>

int main()
{
	double distanceAB, distanceBC, distanceCD; // in km.

	std::cout << "Enter distance between A and B (km): ";
	std::cin >> distanceAB;

	std::cout << "Enter distance between B and C (km): ";
	std::cin >> distanceBC;

	std::cout << "Enter distance between C and D (km): ";
	std::cin >> distanceCD;

	double totalDistance = distanceAB + distanceBC + distanceCD;
	std::cout << "Total distance = " << totalDistance << '\n';

	return 0;
}