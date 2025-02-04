#include <iostream>

int main()
{
    std::cout << "Enter your age: ";
    int age;
    std::cin >> age;

    std::cout << "You are " << age << " years old\n";
    age++;
    std::cout << "In 1 year you will be " << age << " years old\n";
    age++;
    std::cout << "In 2 years you will be " << age << " years old\n";

    return 0;
}