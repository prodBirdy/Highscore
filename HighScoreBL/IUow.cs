using BL.Repos;

namespace BL;

public interface IUow : IDisposable
{
    public GameRepo Games { get; }
    
    public PlayerRepo Players { get; }
    int Commit();
    void Rollback();
}