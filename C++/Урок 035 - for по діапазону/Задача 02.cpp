#include <iostream>

int main()
{
    int sum = 0;
    for (int number : {1, 2, 3, 4, 5})
    {
        sum += number;
    }
    std::cout << "Sum = " << sum << std::endl;

    return 0;
}