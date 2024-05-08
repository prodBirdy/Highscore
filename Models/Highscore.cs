namespace Models;

public class Highscore
{
    public int PlayerId { get; set; }
    
    public string FName { get; set; }
    
    public string LName { get; set; }
    
    public string FullName { get { return $"{FName} {LName}"; } }
    
    public DateTime BirthDate { get; set; }
    
    public DateTime Entry { get; set; }
    
    public DateTime Exit { get; set; }
    
    public string Notes { get; set; }
    
    
}