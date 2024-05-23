using System.Threading.Tasks.Dataflow;
using DAL;
using DTO;
using Models;

namespace BL.Repos;

public class HighscoreRepo : IHighscoreRepo
{
    IDAL _dal;

    public HighscoreRepo(IDAL dal)
    {
        _dal = dal;
    }

    /// <summary>
    /// gets all highscores
    /// </summary>
    /// <returns></returns>
    public List<HighscoreIndex> GetHighscores()
    {
        var highscores = from h in _dal.Highscores
                         select new HighscoreIndex
                         {
                             PlayerId = h.PlayerId,
                             Score = h.Score,
                             Created = h.Created
                         };
        return highscores.ToList();
    }

    /// <summary>
    /// Gets all Highscores for a specific game
    /// </summary>
    /// <param name="gameId"></param>
    /// <returns></returns>
    public List<HighscoreIndex> GetHighscoresByGame(int gameId)
    {
        var highscores = from h in _dal.Highscores
                         where h.GameId == gameId
                         select new HighscoreIndex
                         {
                             PlayerId = h.PlayerId,
                             GameId = h.GameId,
                             Score = h.Score,
                             Created = h.Created
                         };
        return highscores.ToList();
    }

    /// <summary>
    /// gets all highscores for a specific player
    /// </summary>
    /// <param name="playerId"></param>
    /// <returns></returns>
    public List<HighscoreIndex> GetHighscoresByPlayer(int playerId)
    {
        var highscores = from h in _dal.Highscores
                         where h.PlayerId == playerId
                         select new HighscoreIndex
                         {
                             PlayerId = h.PlayerId,
                             GameId = h.GameId,
                             Score = h.Score,
                             Created = h.Created
                         };
        return highscores.ToList();
    }

    /// <summary>
    /// Adds a highscore to the DAL
    /// </summary>
    /// <param name="highscore"></param>
    /// <returns></returns>
    public bool Add(HighscoreIndex highscore)
    {
        Highscore newHighscore = new()
        {
            PlayerId = highscore.PlayerId,
            GameId = highscore.GameId,
            Score = highscore.Score,
            Created = DateTime.Now
        };
        _dal.Highscores.Add(newHighscore);
        return true;
    }

    /// <summary>
    /// Updates a highscore in the DAL
    /// </summary>
    /// <param name="highscore"></param>
    /// <returns></returns>
    public bool Update(HighscoreIndex highscore)
    {
        var highscoreToUpdate =
            _dal.Highscores.Find(h => h.GameId == highscore.GameId && h.PlayerId == highscore.PlayerId);
        if (highscoreToUpdate is null)
        {
            return false;
        }

        highscoreToUpdate.Score = highscore.Score;
        highscoreToUpdate.Created = highscore.Created;
        return true;
    }

    /// <summary>
    /// Deletes a highscore from the DAL by gameId and playerId
    /// </summary>
    /// <param name="gameId"></param>
    /// <param name="playerId"></param>
    /// <returns></returns>
    public bool Delete(int gameId, int playerId)
    {
        var highscoreToDelete = _dal.Highscores.Find(h => h.GameId == gameId && h.PlayerId == playerId);
        if (highscoreToDelete is null)
        {
            return false;
        }

        _dal.Highscores.Remove(highscoreToDelete);
        return true;
    }

    /// <summary>
    /// Deletes a highscore from the DAL
    /// </summary>
    /// <param name="highscore"></param>
    /// <returns></returns>
    public bool Delete(Highscore highscore)
    {
        return _dal.Highscores.Remove(highscore);
    }
}