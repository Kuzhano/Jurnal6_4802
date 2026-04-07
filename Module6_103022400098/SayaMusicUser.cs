class SayaMusicUser
{
    private int id;
    public string Username;
    private List<SayaMusicTrack> uploadTracks;

    public SayaMusicUser(string Username)
    {
        Random random = new Random();
        this.id = random.Next(1000, 10000);
        this.Username = Username;
        uploadTracks = new List<SayaMusicTrack>();
    }

    public int GetTotalPlayCount()
    {
        return uploadTracks.Count;
    }

    public void AddTrack(SayaMusicTrack track)
    {
        uploadTracks.Add(track);
        int currenTrackId = uploadTracks.Count-1;
        Console.WriteLine($"Review Lagu {uploadTracks[currenTrackId].title} oleh {Username}");
    }

    public void PrintAllTrack()
    {
        Console.WriteLine($"User: {Username}");
        for(int i=0; i < uploadTracks.Count-1; i++)
        {
            Console.WriteLine($"Track {i+1} judul: {uploadTracks[i].title}");
        }
    }
}
