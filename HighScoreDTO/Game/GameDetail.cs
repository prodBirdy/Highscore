namespace DTO;

public class GameDetail
{   
    public int GameId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public DateOnly ReleaseDate { get; set; }
    
    public DateTime Entry { get; set; }
    public DateTime? Exit { get; set; }
    public string? Notes { get; set; }
}