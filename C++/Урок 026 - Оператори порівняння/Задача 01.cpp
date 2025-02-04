#include <iostream>

int main()
{
    std::cout << "2 + 5 = ? \\n";
    std::cout << "Enter the answer: ";
    int answer;
    std::cin >> answer;

    std::cout << "If you see 1 - it's true. If 0 - it's false.\\n";
    std::cout << (answer == 2 + 5) << std::endl;

    return 0;
}