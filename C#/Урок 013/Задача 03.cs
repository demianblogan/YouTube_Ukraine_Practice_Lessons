class Program
{
    static void Main()
    {
        int kitchenAreaM = 24;
        int bedroomAreaM = 30;
        int guestRoomAreaM = 42;
        int bathroomAreaM = 10;
        int hallAreaM = 8;

        const int SQ_CM_IN_SQ_M = 10000;
        int houseAreaM = kitchenAreaM + bedroomAreaM + guestRoomAreaM + bathroomAreaM + hallAreaM;
        int houseAreaCM = houseAreaM * SQ_CM_IN_SQ_M;

        System.Console.WriteLine("Kitchen    = " + kitchenAreaM + " m^2");
        System.Console.WriteLine("Bedroom    = " + bedroomAreaM + " m^2");
        System.Console.WriteLine("Guest room = " + guestRoomAreaM + " m^2");
        System.Console.WriteLine("Bathroom   = " + bathroomAreaM + " m^2");
        System.Console.WriteLine("Hall       = " + hallAreaM + " m^2");

        System.Console.WriteLine();

        System.Console.WriteLine("House = " + houseAreaCM + " cm^2");
    }
}