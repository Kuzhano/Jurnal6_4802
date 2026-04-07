using System.Diagnostics;

class SayaMusicUser
{
    private int id;
    public string Username;
    private List<SayaMusicTrack> uploadTracks;

    public SayaMusicUser(string Username)
    {
        Debug.Assert(Username.Length <= 100, "Username maksimal 100 karakter.");
        Debug.Assert(Username != null, "Username tidak boleh null.");

        Random random = new Random();
        this.id = random.Next(1000, 10000);
        this.Username = Username;
        uploadTracks = new List<SayaMusicTrack>();
    }

    public int GetTotalPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var item in uploadTracks)
        {
            totalPlayCount += item.getPlayCount();
        }

        return totalPlayCount;
    }

    public void AddTrack(SayaMusicTrack track)
    {
        if(track == null)
        {
            throw new ArgumentException("Track tidak boleh null");
        }
        uploadTracks.Add(track);

        int currenTrackId = uploadTracks.Count-1;
        Console.WriteLine($"Review Lagu {uploadTracks[currenTrackId].title} oleh {Username}");
    }

    public void PrintAllTrack()
    {
        Console.WriteLine($"User: {Username}");
        for(int i=0; i < 8; i++)
        {
            Console.WriteLine($"Track {i+1} judul: {uploadTracks[i].title}");
        }
    }
}
