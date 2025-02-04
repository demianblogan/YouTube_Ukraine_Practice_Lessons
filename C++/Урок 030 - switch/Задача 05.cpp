#include <iostream>

int main()
{
	char answer;

	std::cout << "Let's play a game!\n\n";

	// ----- QUESTION #1 BLOCK -----
	std::cout << "Question 1:\n";
	std::cout << "2 + 2 = ...\n";
	std::cout << "a) 4\n";
	std::cout << "b) 8\n";
	std::cout << "c) 2\n";
	std::cout << "d) 5\n";
	std::cin >> answer;

	switch (answer)
	{
	case 'a': case 'A':
		std::cout << "You are right! Let's go to the next question...\n\n";

		// ----- QUESTION #2 BLOCK -----
		std::cout << "Question 2:\n";
		std::cout << "How many planets are there in the Solar System?:\n";
		std::cout << "a) 7 \n";
		std::cout << "b) 8 \n";
		std::cout << "c) 9 \n";
		std::cout << "d) 10\n";
		std::cin >> answer;

		switch (answer)
		{
		case 'b': case 'B':
			std::cout << "You are right! Let's go to the last question...\n\n";

			// ----- QUESTION #3 BLOCK -----
			std::cout << "Question 3:\n";
			std::cout << "What dog breed looks like sausage?:\n";
			std::cout << "a) Bulldog \n";
			std::cout << "b) Pug \n";
			std::cout << "c) Dachshund \n";
			std::cout << "d) Labrador \n";
			std::cin >> answer;

			switch (answer)
			{
			case 'c': case 'C':
				std::cout << "You are right! You win\n";
				break;

			case 'a': case 'A':
			case 'b': case 'B':
			case 'd': case 'D':
				std::cout << "You are wrong! You lose\n";
				break;

			default:
				std::cout << "Incorrect input\n";
				break;
			}

		case 'a': case 'A':
		case 'c': case 'C':
		case 'd': case 'D':
			std::cout << "You are wrong! You lose\n";
			break;

		default:
			std::cout << "Incorrect input\n";
			break;
		}

		break;

	case 'b': case 'B':
	case 'c': case 'C':
	case 'd': case 'D':
		std::cout << "You are wrong! You lose\n";
		break;

	default:
		std::cout << "Incorrect input\n";
		break;
	}

	return 0;
}