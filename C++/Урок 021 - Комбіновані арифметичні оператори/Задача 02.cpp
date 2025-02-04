#include <iostream>

int main()
{
	std::cout << "Enter item cost: $";
	double itemCost;
	std::cin >> itemCost;

	double taxFactor = 0.05; // in %.

	std::cout << "Cost (without taxes): $" << itemCost << '\n';
	itemCost += itemCost * taxFactor;
	std::cout << "Cost (with 5%-tax): $" << itemCost << '\n';

	return 0;
}