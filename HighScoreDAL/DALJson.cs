using System.Text.Json;
using Models;

namespace DAL;

public class DALJson : DAL
{
    public override int Save()
    {
        int count = 0;
        if (_games is not null)
        {
            try
            {
                using FileStream fileStream = File.Create(FilePath + "Games.json");
                JsonSerializer.SerializeAsync(fileStream, _games);
                count += _games.Count;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        if (_players is not null)
        {
            try 
            {
                using FileStream fileStream = File.Create(FilePath + "Players.json");
                JsonSerializer.SerializeAsync(fileStream, _players);
                count += _players.Count;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        if (_highscores is not null)
        {
            try
            {
                using FileStream fileStream = File.Create(FilePath + "Highscore.json");
                JsonSerializer.SerializeAsync(fileStream, _highscores);
                count += _highscores.Count;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        return count;
    }

    protected override List<Game> LoadGames()
    {
        string LoadPath = FilePath + "Games.json";
        if (File.Exists( LoadPath ) )
        {
            try
            {
                using FileStream fileStream = File.OpenRead(LoadPath);
                return JsonSerializer.Deserialize<List<Game>>( fileStream );
            }
            catch (Exception e)
            {
                return new List<Game>();
            }
        }
        return new List<Game>();
    }

    protected override List<Player> LoadPlayers()
    {
        string LoadPath = FilePath + "Players.json";
        if (File.Exists( LoadPath ) )
        {
            try
            {
                using FileStream fileStream = File.OpenRead(LoadPath);
                return JsonSerializer.Deserialize<List<Player>>( fileStream );
            }
            catch (Exception e)
            {
                return new List<Player>();
            }
        }
        return new List<Player>();
    }

    protected override List<Highscore> LoadHighscores()
    {
        string LoadPath = FilePath + "Highscore.json";
        if (File.Exists( LoadPath ) )
        {
            try
            {
                using FileStream fileStream = File.OpenRead(LoadPath);
                return JsonSerializer.Deserialize<List<Highscore>>( fileStream );
            }
            catch (Exception e)
            {
                return new List<Highscore>();
            }
        }
        return new List<Highscore>();
    }
}