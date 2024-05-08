using System.Runtime.InteropServices.JavaScript;

namespace Models;

public class Game : Detail
{
    public int GameId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public DateOnly ReleaseDate { get; set; }

    
    public Game()
    {
        Entry = DateTime.Now;
        LastModified = Entry;
    }
}