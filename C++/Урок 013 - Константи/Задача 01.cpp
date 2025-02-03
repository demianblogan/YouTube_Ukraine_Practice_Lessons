#include <iostream>

int main()
{
	const double PI = 3.1415;

	double radius = 20;
	double diameter = radius * 2;
	double area = PI * radius * radius;
	double length = 2 * PI * radius;

	std::cout << "R = " << radius << '\n';
	std::cout << "D = " << diameter << '\n';
	std::cout << "S = " << area << '\n';
	std::cout << "L = " << length << '\n';

	return 0;
}