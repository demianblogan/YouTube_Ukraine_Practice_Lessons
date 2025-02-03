#include <iostream>

int main()
{
	int employeesCount;
	double employeeSalary; // in $.
	int workYears;

	std::cout << "Enter the number of employees: ";
	std::cin >> employeesCount;
	std::cout << "Enter the salary of an employee: ";
	std::cin >> employeeSalary;
	std::cout << "Enter the number of years of the factory working: ";
	std::cin >> workYears;

	double payment = employeesCount * employeeSalary * workYears; // in $.
	std::cout << "You paid $" << payment << '\n';

	return 0;
}