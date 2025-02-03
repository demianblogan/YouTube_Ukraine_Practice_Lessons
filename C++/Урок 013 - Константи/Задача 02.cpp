#include <iostream>

int main()
{
	const int M_IN_KM = 1000;
	const int CM_IN_M = 100;
	const int MM_IN_CM = 10;

	int distanceInKM = 15;
	int distanceInM = distanceInKM * M_IN_KM;
	int distanceInCM = distanceInM * CM_IN_M;
	int distanceInMM = distanceInCM * MM_IN_CM;

	std::cout << distanceInKM << "km = " << distanceInM << "m = ";
	std::cout << distanceInCM << "cm = " << distanceInMM << "mm.\n";

	return 0;
}