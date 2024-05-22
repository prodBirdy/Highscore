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

    /// <summary>
    /// gets all players
    /// </summary>
    /// <returns></returns>
    public List<PlayerIndex> GetPlayers()
    {
        var players = from p in _dal.Players
            where p.Exit == null || p.Exit > DateTime.Now
            select new PlayerIndex()
            {
                PlayerId = p.PlayerId,
                FullName = p.FName + " " + p.LName,
                BirthDay = p.BirthDay,
            };
        return players.ToList();
    }

    /// <summary>
    /// gets all players for use in a combobox
    /// </summary>
    /// <returns></returns>
    public List<SelectItem> GetPlayerSelect()
    {
        var players = from p in _dal.Players
            where p.Exit == null || p.Exit > DateTime.Now
            select new SelectItem()
            {
                ValueMember = p.PlayerId,
                DisplayMember = p.FName + " " + p.LName,
            };
        return players.ToList();
    }

    /// <summary>
    /// gets a player by playerId
    /// </summary>
    /// <param name="playerId"></param>
    /// <returns></returns>
    public PlayerDetail GetPlayer(int playerId)
    {
        var player = _dal.Players.Find(p => p.PlayerId == playerId || p.Exit > DateTime.Now);
        if (player is null)
        {
            return null;
        }

        PlayerDetail playerDetail = new()
        {
            PlayerId = player.PlayerId,
            FName = player.FName,
            LName = player.LName,
            BirthDay = player.BirthDay,
            Entry = player.Entry,
            Exit = player.Exit,
            Notes = player.Notes,
        };
        return playerDetail;
    }

    /// <summary>
    /// get all players by game
    /// </summary>
    /// <param name="gameId"></param>
    /// <returns></returns>
    public List<PlayerIndex> GetPlayersByGame(int gameId)
    {
        var players = from p in _dal.Players
            join h in _dal.Highscores on p.PlayerId equals h.PlayerId
            where h.GameId == gameId && p.Exit == null || p.Exit > DateTime.Now
            select new PlayerIndex()
            {
                PlayerId = p.PlayerId,
                FullName = p.FName + " " + p.LName,
                BirthDay = p.BirthDay,
            };
        return players.ToList();
    }

    /// <summary>
    /// Adds a player to the database
    /// </summary>
    /// <param name="player"></param>
    /// <returns></returns>
    public bool Add(PlayerAdd player)
    {
        Player newPlayer;

        if (_dal.Players.Count == 0) {
            newPlayer = new()
            {
                PlayerId = 1,
                FName = player.FName,
                LName = player.LName,
                BirthDay = player.BirthDay,
                Entry = player.Entry,
                Exit = player.Exit,
                Notes = player.Notes,
                PwHash = player.Pw,
            };


        }
        else {
            newPlayer = new()
            {
                PlayerId = _dal.Players.Max(p => p.PlayerId) + 1,
                FName = player.FName,
                LName = player.LName,
                BirthDay = player.BirthDay,
                Entry = player.Entry,
                Exit = player.Exit,
                Notes = player.Notes,
                PwHash = player.Pw,
            };
        }
        _dal.Players.Add(newPlayer);

        return true;
    }

    /// <summary>
    /// Updates a player in the database
    /// </summary>
    /// <param name="player"></param>
    /// <returns></returns>
    public bool Update(PlayerDetail player)
    {
        var playerToUpdate = _dal.Players.Find(p => p.PlayerId == player.PlayerId);
        if (playerToUpdate is null)
        {
            return false;
        }

        playerToUpdate.FName = player.FName;
        playerToUpdate.LName = player.LName;
        playerToUpdate.BirthDay = player.BirthDay;
        playerToUpdate.Entry = player.Entry;
        playerToUpdate.Exit = player.Exit;
        playerToUpdate.Notes = player.Notes;
        return true;
    }

    /// <summary>
    /// deletes a player from the database by playerId
    /// </summary>
    /// <param name="playerId"></param>
    /// <returns></returns>
    public bool Delete(int playerId)
    {
        var playerToDelete = _dal.Players.Find(p => p.PlayerId == playerId);
        if (playerToDelete is null)
        {
            return false;
        }

        _dal.Players.Remove(playerToDelete);
        return true;
    }

    /// <summary>
    /// deletes a player from the database
    /// </summary>
    /// <param name="player"></param>
    /// <returns></returns>
    public bool Delete(Player player)
    {
        return _dal.Players.Remove(player);
    }
}