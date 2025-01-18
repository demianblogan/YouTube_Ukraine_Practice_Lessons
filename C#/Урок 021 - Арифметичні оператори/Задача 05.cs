class Program
{
    static void Main()
    {
        const int SEC_IN_MIN = 60;

        int videoDurationInSeC = 12345;
        int videoDurationInMin = videoDurationInSeC / SEC_IN_MIN;
        int videoRestDurationInSec = videoDurationInSeC & SEC_IN_MIN;

        System.Console.WriteLine("Video is " + videoDurationInMin + "m " + videoRestDurationInSec + "s long");
    }
}