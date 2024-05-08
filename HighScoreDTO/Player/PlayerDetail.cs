namespace DTO;

public class PlayerDetail
{
    public int PlayerId { get; set; }
    public string FName { get; set; } = string.Empty;
    public string LName { get; set; } = string.Empty;
    public DateOnly BirthDay { get; set; }
    
    public DateTime Entry { get; set; }
    public DateTime? Exit { get; set; }
    public string? Notes { get; set; }

}