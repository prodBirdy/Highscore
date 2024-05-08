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
    public List<GameIndex> GetGames()
    {
        var games = from g in _dal.Games
            where g.Exit == null || g.Exit < DateTime.Now
                select new GameIndex
                {
                    GameId = g.GameId,
                    Title = g.Title,
                    ReleaseDate = g.ReleaseDate
                };
        return games.ToList();
        
    }

    public List<SelectItem> GetGameSelect()
    {
        throw new NotImplementedException();
    }

    public GameDetail GetGame(int gameId)
    {
        throw new NotImplementedException();
    }

    public List<GameIndex> GetGamesByPlayer(int playerId)
    {
        throw new NotImplementedException();
    }

    public bool Add(GameDetail game)
    {
        throw new NotImplementedException();
    }

    public bool Update(GameDetail game)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int gameId)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Game game)
    {
        throw new NotImplementedException();
    }
    
}