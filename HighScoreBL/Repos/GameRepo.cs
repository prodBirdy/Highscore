using System.Threading.Tasks.Dataflow;
using DAL;
using DTO;
using Models;

namespace BL.Repos;

public class GameRepo : IGameRepo
{
    IDAL _dal;
    
    public GameRepo(IDAL dal)
    {
        _dal = dal;
    }
    /// <summary>
    /// Gets all active Games from DAL
    /// </summary>
    /// <returns></returns>
    public List<GameIndex> GetGames()
    {
        var games = from g in _dal.Games
            where g.Exit == null || g.Exit > DateTime.Now
                select new GameIndex
                {
                    GameId = g.GameId,
                    Title = g.Title,
                    ReleaseDate = g.ReleaseDate
                };
        return games.ToList();
        
    }

    /// <summary>
    /// Gets all active Games for use in ComboBox
    /// </summary>
    /// <returns></returns>
    public List<SelectItem> GetGameSelect()
    {
        var games = from g in _dal.Games
            where g.Exit == null || g.Exit > DateTime.Now
            select new SelectItem()
            {
                ValueMember = g.GameId,
                DisplayMember = g.Title,
            };
        return games.ToList();
    }

    /// <summary>
    /// Gets Game by id
    /// </summary>
    /// <param name="gameId"></param>
    /// <returns></returns>
    public GameDetail GetGame(int gameId)
    {
        var game = _dal.Games.Find(g => g.GameId == gameId || g.Exit > DateTime.Now );
        if (game is null)
        {
            return null;
        }
        GameDetail gameDetail = new()
        {
            GameId = game.GameId,
            Title = game.Title,
            ReleaseDate = game.ReleaseDate,
            Exit = game.Exit,
            Notes = game.Notes,
        };
        return gameDetail;
    }

    /// <summary>
    /// Gets all Games from a Player
    /// </summary>
    /// <param name="playerId"></param>
    /// <returns></returns>
    public List<GameIndex> GetGamesByPlayer(int playerId)
    {
        var games = from g in _dal.Games
            join s in _dal.Highscores on g.GameId equals s.GameId
            where s.PlayerId == playerId
            select new GameIndex
            {
                GameId = g.GameId,
                Title = g.Title,
                ReleaseDate = g.ReleaseDate
            };
        return games.ToList();
    }

    /// <summary>
    /// Add game to DAL
    /// </summary>
    /// <param name="game"></param>
    /// <returns></returns>
    public bool Add(GameDetail game)
    {
        Game newGame = new()
        {
            GameId = game.GameId,
            Title = game.Title,
            ReleaseDate = game.ReleaseDate,
            Exit = game.Exit,
            Notes = game.Notes  
        };
        _dal.Games.Add(newGame);
        return true;
    }

    /// <summary>
    /// Update Game 
    /// </summary>
    /// <param name="game"></param>
    /// <returns></returns>
    public bool Update(GameDetail game)
    {
        var gameToUpdate = _dal.Games.Find(g => g.GameId == game.GameId);
        if (gameToUpdate is null)
        {
            return false;
        }

        gameToUpdate.Title = game.Title;
        gameToUpdate.ReleaseDate = game.ReleaseDate;
        gameToUpdate.Exit = game.Exit;
        gameToUpdate.Notes = game.Notes;
        return true;
    }

    /// <summary>
    /// Delete Game
    /// </summary>
    /// <param name="gameId"></param>
    /// <returns></returns>
    public bool Delete(int gameId)
    {
        var gameToDelete = _dal.Games.Find(g => g.GameId == gameId);
        if (gameToDelete is null)
        {
            return false;
        }
        _dal.Games.Remove(gameToDelete);
        return true;
    }

    /// <summary>
    /// Delete Game
    /// </summary>
    /// <param name="game"></param>
    /// <returns></returns>
    public bool Delete(Game game)
    {
        return _dal.Games.Remove(game);
    }
    
}