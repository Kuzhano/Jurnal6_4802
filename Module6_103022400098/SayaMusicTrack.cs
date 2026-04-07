using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    public string title;
    private int playCount;

    public SayaMusicTrack(String title)
    {
        Debug.Assert(title.Length <= 200, "Judul maksimal 200 karakter.");
        Debug.Assert(title != null, "Judul tidak boleh null.");


        Random random = new Random();
        this.id = random.Next(1000, 10000);
        this.playCount = 0;
        this.title = title;
    }

    public void increasePlayCount(int count)
    {
        Debug.Assert(count <= 25000000, "Penambahan play count maksimal 10.000.000.");
        Debug.Assert(count >= 0, "Penambahan tidak boleh negatif.");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"[ERROR] Terjadi Overflow: {ex.Message}");
            throw;
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

    public int getPlayCount()
    {
        return playCount;
    }
}
