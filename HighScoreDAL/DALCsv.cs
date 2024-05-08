using Models;

namespace DAL;

public class DALCsv : DAL
{
    public override int Save()
    {
        int count = 0;
        if (_games is not null)
        {
            try
            {
                using StreamWriter file = new(FilePath + "Games.csv");
                foreach (var game in _games)
                {
                    file.WriteLine($"{game.GameId};{game.Title};{game.ReleaseDate};{game.Publisher};{game.Exit};{game.Entry};{game.LastModified};{game.Notes};{game.ModifiedBy}");
                }
                
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
                using StreamWriter file = new(FilePath + "Players.csv");
                foreach (var player in _players)
                {
                    file.WriteLine($"{player.PlayerId};{player.Exit};{player.LastModified};{player.ModifiedBy};{player.Entry};{player.Notes};{player.BirthDay};{player.FName};{player.LName};{player.PwHash}");
                }
                
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
                using StreamWriter file = new(FilePath + "Highscore.csv");
                foreach (var highscore in _highscores)
                {
                    file.WriteLine($"{highscore.Score};{highscore.GameId};{highscore.PlayerId};{highscore.Created}");
                }
                
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
        List<Game> games = new();
        string LoadPath = FilePath + "Games.csv";
        if (File.Exists( LoadPath ) )
        {
            try
            {
                using StreamReader file = new( LoadPath );
                string line;
                while ((line = file.ReadLine()) is not null)
                {
                    string[] parts = line.Split(';');
                    games.Add(new Game
                    { 
                        GameId = int.Parse(parts[0]),
                        Title = parts[1],
                        ReleaseDate = DateOnly.Parse(parts[2]),
                        Publisher = parts[3],
                        Exit = DateTime.Parse(parts[4]),
                        Entry = DateTime.Parse(parts[5]),
                        LastModified = DateTime.Parse(parts[6]),
                        Notes = parts[7],
                        ModifiedBy = parts[8]
                    });
                }
            }
            catch (Exception e)
            {
                return games;
            }
        }
        return games;
    }

    protected override List<Player> LoadPlayers()
    {
        List<Player> players = new();
        string LoadPath = FilePath + "Players.csv";
        if (File.Exists( LoadPath ) )
        {
            try
            {
                using StreamReader file = new( LoadPath );
                string line;
                while ((line = file.ReadLine()) is not null)
                {
                    string[] parts = line.Split(';');
                    players.Add(new Player
                    {
                        PlayerId = int.Parse(parts[0]),
                        Exit = DateTime.Parse(parts[1]),
                        LastModified = DateTime.Parse(parts[2]),
                        ModifiedBy = parts[3],
                        Entry = DateTime.Parse(parts[4]),
                        Notes = parts[5],
                        BirthDay = DateOnly.Parse(parts[6]),
                        FName = parts[7],
                        LName = parts[8],
                        PwHash = parts[9]
                    });
                }
            }
            catch (Exception e)
            {
                return players;
            }
        }
        return players;
    }

    protected override List<Highscore> LoadHighscores()
    {
        List<Highscore> highscores = new();
        string LoadPath = FilePath + "Highscore.csv";
        if (File.Exists( LoadPath ) )
        {
            try
            {
                using StreamReader file = new( LoadPath );
                string line;
                while ((line = file.ReadLine()) is not null)
                {
                    string[] parts = line.Split(';');
                    highscores.Add(new Highscore
                    {
                        Score = int.Parse(parts[0]),
                        GameId = int.Parse(parts[1]),
                        PlayerId = int.Parse(parts[2]),
                        Created = DateTime.Parse(parts[3])

                    });
                }
            }
            catch (Exception e)
            {
                return highscores;
            }
        }
        return highscores;
    }
}