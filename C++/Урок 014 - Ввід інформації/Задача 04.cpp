#include <iostream>

int main()
{
	std::cout << "Enter your age: ";
	int age;
	std::cin >> age;

	std::cout << "In 10 years your age will be " << age + 10 << '\n';

	return 0;
}