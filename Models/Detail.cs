namespace Models;

public class Detail
{
    public string? Notes { get; set; }
    public DateTime Entry { get; set; }
    public DateTime? Exit { get; set; }
    public DateTime? LastModified { get; set; }
    public string ModifiedBy { get; set; } = string.Empty;
}