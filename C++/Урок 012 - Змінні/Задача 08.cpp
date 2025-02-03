#include <iostream>

int main()
{
	int myApples = 3, nastyaApples = 10, igorApples = 7;
	int allApples = myApples + nastyaApples + igorApples;

	std::cout << "I have " << myApples << " apples.\n";
	std::cout << "Nastya has " << nastyaApples << " apples.\n";
	std::cout << "Igor has " << igorApples << " apples.\n";
	std::cout << "We have " << allApples << " apples.\n";

	return 0;
}