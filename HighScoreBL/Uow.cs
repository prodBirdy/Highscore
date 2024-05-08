using BL.Repos;
using DAL;

namespace BL;

public class Uow : IUow
{
    IDAL dal;
    
    GameRepo? gameRepo;
    PlayerRepo? playerRepo;
    
    public Uow(DALType dalType)
    {
        dal = dalType switch
        {
            DALType.Json => new DALJson(),
            DALType.XML => new DALXml(),
            _ => new DALCsv()
            
        };
    }

    public GameRepo Games => gameRepo ??= new GameRepo(dal);
    
    public PlayerRepo Players => playerRepo ??= new PlayerRepo(dal);

    public void Dispose()
    {
    }

    public int Commit()
    {
        return dal.Save();
    }

    public void Rollback()
    {
        dal.Rollback();
    }
    
}