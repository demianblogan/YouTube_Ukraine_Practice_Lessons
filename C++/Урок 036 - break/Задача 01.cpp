#include <iostream>

int main()
{
    int waterDrunkSum = 0;
    const int WATER_DRUNK_FOR_WARNING = 6000;
    const int WATER_DRUNK_FOR_DEATH = 8000;

    while (true)
    {
        std::cout << "How many milliliters of water have you drunk today?: ";
        int waterDrunkToday;
        std::cin >> waterDrunkToday;

        waterDrunkSum += waterDrunkToday;

        if (waterDrunkSum >= WATER_DRUNK_FOR_DEATH)
        {
            break;
        }
        else if (waterDrunkSum >= WATER_DRUNK_FOR_WARNING)
        {
            std::cout << "Maybe you should stop drinking.\n";
        }
    }

    std::cout << "Congratulations. You're dead.\n";

    return 0;
}