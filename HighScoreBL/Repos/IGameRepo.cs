using DTO;
using Models;

namespace BL.Repos;

internal interface IGameRepo
{
    List<GameIndex> GetGames();
    
    List<SelectItem> GetGameSelect();
    
    GameDetail GetGame(int gameId);
    
    List<GameIndex> GetGamesByPlayer(int playerId);
    
    bool Add(GameDetail game);
    
    bool Update(GameDetail game);
    
    bool Delete(int gameId);
    
    bool Delete(Game game);
}