namespace Models;

public class Player : Detail
{
    public int PlayerId { get; set; }
    public string FName { get; set; } = string.Empty;
    public string LName { get; set; } = string.Empty;
    public string PwHash { get; set; } = string.Empty;
    public string FullName { get { return $"{FName} {LName}"; } }
    public DateOnly BirthDay { get; set; }
    
    public Player()
    {
        Entry = DateTime.Now;
        LastModified = Entry;
    }
}