#include <iostream>

int main()
{
    int peopleInCity;

    do
    {
        std::cout << "How many people live in your city?: ";
        std::cin >> peopleInCity;

        if (peopleInCity <= 0)
        {
            std::cout << "Incorrect number.\n";
        }
    } while (peopleInCity <= 0);

    int ukrainians;

    do
    {
        std::cout << "How many of them speak Ukrainian?: ";
        std::cin >> ukrainians;

        if (ukrainians <= 0 || ukrainians > peopleInCity)
        {
            std::cout << "Incorrect number.\n";
        }
    } while (ukrainians <= 0);

    double urkainiansPercentege = ukrainians * 100.0 / peopleInCity;
    std::cout << "There are " << urkainiansPercentege << "% of ukrainian people.\\n";

	return 0;
}