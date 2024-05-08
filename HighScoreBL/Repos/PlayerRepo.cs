using DAL;
using DTO;
using Models;

namespace BL.Repos;

public class PlayerRepo : IPlayerRepo
{
    IDAL? _dal;
    
    public PlayerRepo(IDAL dal)
    {
        _dal = dal;
    }
    public List<PlayerIndex> GetPlayers()
    {
        var players = from g in _dal.Players
            where g.Exit == null || g.Exit < DateTime.Now
            select new PlayerIndex()
            {
                PlayerId = g.PlayerId,
                FullName = g.FName + " " + g.LName,
            };
        return players.ToList();
        
    }

    public List<SelectItem> GetPlayerSelect()
    {
        throw new NotImplementedException();
    }

    public PlayerDetail GetPlayer(int playerId)
    {
        throw new NotImplementedException();
    }

    public List<PlayerIndex> GetPlayersByGame(int gameId)
    {
        throw new NotImplementedException();
    }

    public bool Add(PlayerAdd player)
    {
        throw new NotImplementedException();
    }

    public bool Update(PlayerDetail player)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int playerId)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Player player)
    {
        throw new NotImplementedException();
    }
}