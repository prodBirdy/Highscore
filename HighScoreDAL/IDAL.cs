using Models;

namespace DAL;

public interface IDAL
{
    List<Game> Games { get; }
    List<Player> Players { get; }
    List<Highscore> Highscores { get; }

    int Save();
    void Rollback();
    
    public string FilePath { get; set; }
    
    #region Events
    /// <summary>
    /// When Players are loaded
    /// </summary>
    public EventHandler<string>? PlayersLoaded { get; set; }
    /// <summary>
    /// When Games are loaded
    /// </summary>
    public EventHandler<string>? GamesLoaded { get; set; }
    /// <summary>
    /// When Highscores are loaded
    /// </summary>
    public EventHandler<string>? HighscoresLoaded { get; set; }
    
    /// <summary>
    /// When Players are saved
    /// </summary>
    public EventHandler<string>? PlayerSaved { get; set; }
    /// <summary>
    /// When Games are saved
    /// </summary>
    public EventHandler<string>? GameSaved { get; set; }
    /// <summary>
    /// When Highscores are saved
    /// </summary>
    public EventHandler<string>? HighscoresSaved { get; set; }
    
    #endregion
}