using BL.Repos;
using DAL;

namespace BL;

public class Uow : IUow
{
    IDAL dal;
    
    GameRepo? gameRepo;
    PlayerRepo? playerRepo;
    HighscoreRepo? highscoreRepo;
    
    
    public Uow(DALType dalType)
    {
        dal = dalType switch
        {
            DALType.Json => new DALJson(),
            DALType.XML => new DALXml(),
            _ => new DALCsv()
            
        };
    }
    
    /// <summary>
    /// GameRepo for handling Game data
    /// </summary>
    public GameRepo Games => gameRepo ??= new GameRepo(dal);
    /// <summary>
    /// PlayerRepo for handling Player data
    /// </summary>
    public PlayerRepo Players => playerRepo ??= new PlayerRepo(dal);
    /// <summary>
    /// HighscoreRepo for handling Highscore data
    /// </summary>
    public HighscoreRepo Highscores => highscoreRepo ??= new HighscoreRepo(dal);

    public void Dispose()
    {
    }

    /// <summary>
    /// commits changes to the DAL
    /// </summary>
    /// <returns></returns>
    public int Commit()
    {
        
        return dal.Save();
    }
/// <summary>
/// rolls back changes to the DAL
/// </summary>
    public void Rollback()
    {
        dal.Rollback();
    }
    
}