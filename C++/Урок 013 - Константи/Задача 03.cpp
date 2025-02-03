#include <iostream>

int main()
{
	const double CM_IN_INCH = 2.54;

	double inches = 19;
	double centimeters = inches * CM_IN_INCH;

	std::cout << inches << "inch = " << centimeters << "cm.\n";

	return 0;
}