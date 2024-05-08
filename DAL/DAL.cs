using Models;

namespace DAL;

public abstract class DAL : IDAL
{
    private List<Game>? _games;
    private List<Player>? _players;
    private List<Highscore>? _highscores;

    public List<Game> Games => _games ??= LoadGames();
    public List<Player> Players => _players ??= LoadPlayers();
    public List<Highscore> Highscores => _highscores ??= LoadHighscores();

    public abstract int Save();

    public void Rollback()
    {
        _games = null;
        _players = null;
        _highscores = null;
    }
    
    protected abstract List<Game> LoadGames();
    protected abstract List<Player> LoadPlayers();
    protected abstract List<Highscore> LoadHighscores();
    
    public EventHandler<string>? PlayersLoaded { get; set; }
    public EventHandler<string>? GamesLoaded { get; set; }
    public EventHandler<string>? HighscoresLoaded { get; set; }
    public EventHandler<string>? PlayerSaved { get; set; }
    public EventHandler<string>? GameSaved { get; set; }
    public EventHandler<string>? HighscoresSaved { get; set; }
}