#include <iostream>

int main()
{
    std::cout << "Enter your weight (kg): ";
    double weight;
    std::cin >> weight;

    std::cout << "Your weight (full): " << weight << " kg.\n";
    std::cout << "Your weight (integer): " << static_cast<int>(weight) << " kg.\n";

    return 0;
}