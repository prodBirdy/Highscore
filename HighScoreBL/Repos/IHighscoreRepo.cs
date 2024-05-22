using DTO;
using Models;

namespace BL.Repos;

internal interface IHighscoreRepo
{
    List<HighscoreIndex> GetHighscores();
    
    List<HighscoreIndex> GetHighscoresByGame(int gameId);
    
    List<HighscoreIndex> GetHighscoresByPlayer(int playerId);
    
    
    bool Add(HighscoreIndex highscore);
    
    bool Update(HighscoreIndex highscore);
    
    bool Delete(int gameId , int playerId);
    
    bool Delete(Highscore highscore);
    
}