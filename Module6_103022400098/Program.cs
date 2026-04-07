class Program
{
    static void Main(string[] args)
    {
        SayaMusicUser user = new SayaMusicUser("Wawan");

        SayaMusicTrack music1 = new SayaMusicTrack("Machine Love");
        SayaMusicTrack music2 = new SayaMusicTrack("Order");
        SayaMusicTrack music3 = new SayaMusicTrack("Idol");
        SayaMusicTrack music4 = new SayaMusicTrack("Gaktau 1");
        SayaMusicTrack music5 = new SayaMusicTrack("Gaktau 2");
        SayaMusicTrack music6 = new SayaMusicTrack("Gaktau 3");
        SayaMusicTrack music7 = new SayaMusicTrack("Gaktau 4");
        SayaMusicTrack music8 = new SayaMusicTrack("Gaktau 5");
        SayaMusicTrack music9 = new SayaMusicTrack("Gaktau 6");
        SayaMusicTrack music10 = new SayaMusicTrack("Gaktau 7");

        user.AddTrack(music1);
        user.AddTrack(music2);
        user.AddTrack(music3);
        user.AddTrack(music4);
        user.AddTrack(music5);
        user.AddTrack(music6);
        user.AddTrack(music7);
        user.AddTrack(music8);
        user.AddTrack(music9);
        user.AddTrack(music10);

        user.PrintAllTrack();
    }
}