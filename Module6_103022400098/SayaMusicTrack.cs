class SayaMusicTrack
{
    private int id;
    public string title;
    private int playCount;

    public SayaMusicTrack(String title)
    {
        Random random = new Random();
        this.id = random.Next(1000, 10000);
        this.playCount = 0;
        this.title = title;
    }

    public void increasePlayCount(int count)
    {
        if(count <= 0)
        {
            Console.WriteLine("Input nilai salah");
        }
        else
        {
            Console.WriteLine("Input berhasil");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("========== Track Details ==========");
        Console.WriteLine($"ID          : {this.id}");
        Console.WriteLine($"Title       : {this.title}");
        Console.WriteLine($"Play Count  : {this.playCount}");
        Console.WriteLine("===================================\n");
    }
}
