class Program
{
    static void Main()
    {
        int peopleWhoLiveInCity;

        do
        {
            System.Console.WriteLine("Enter positive number of people who live in your city: ");
            peopleWhoLiveInCity = System.Convert.ToInt32(System.Console.ReadLine());

        } while (peopleWhoLiveInCity <= 0);

        int peopleWhoSpeakUkrainian;

        do
        {
            System.Console.WriteLine("Enter positive number of people who speak ukrainian in your city: ");
            peopleWhoSpeakUkrainian = System.Convert.ToInt32(System.Console.ReadLine());

            if (peopleWhoSpeakUkrainian > peopleWhoLiveInCity)
                System.Console.WriteLine("Number of people speaking ukrainian can't be greater than people living in your city.");

        } while (peopleWhoSpeakUkrainian <= 0 || peopleWhoSpeakUkrainian > peopleWhoLiveInCity);

        int chanceUserSpeaksUkrainian = (int)((double)peopleWhoSpeakUkrainian / peopleWhoLiveInCity * 100); // in %
        System.Console.WriteLine($"There is {chanceUserSpeaksUkrainian}% chance you speak ukrainian.");
    }
}