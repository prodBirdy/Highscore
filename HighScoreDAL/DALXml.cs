using System.Text.Json;
using System.Xml.Serialization;
using Models;

namespace DAL;

public class DALXml : DAL
{
    /// <summary>
    /// Save all data to xml files
    /// </summary>
    /// <returns></returns>
    public override int Save()
    {
        int count = 0;
        if (_games is not null)
        {
            try
            {
                using FileStream fileStream = File.Create(FilePath + "Games.xml");
                var xmlSerializer = new XmlSerializer(typeof(List<Game>));
                xmlSerializer.Serialize(fileStream, _games);
                count += _games.Count;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        if (_players is not null)
        {
            try 
            {
                using FileStream fileStream = File.Create(FilePath + "Players.xml");
                var xmlSerializer = new XmlSerializer(typeof(List<Player>));
                xmlSerializer.Serialize(fileStream, _players);
                count += _players.Count;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        if (_highscores is not null)
        {
            try
            {
                using FileStream fileStream = File.Create(FilePath + "Highscore.xml");
                var xmlSerializer = new XmlSerializer(typeof(List<Highscore>));
                xmlSerializer.Serialize(fileStream, _highscores);
                count += _highscores.Count;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        return count;
    }

    /// <summary>
    /// Load all games from xml file
    /// </summary>
    /// <returns></returns>
    protected override List<Game> LoadGames()
    {
        string LoadPath = FilePath + "Games.xml";
        if (File.Exists( LoadPath ) )
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof( List<Game> ));
                using FileStream fileStream = File.OpenRead( LoadPath );
                return (List<Game>)xmlSerializer.Deserialize( fileStream );
            }
            catch (Exception e)
            {
                return new List<Game>();
            }
        }
        return new List<Game>();
    }

    /// <summary>
    /// Load all players from xml file
    /// </summary>
    /// <returns></returns>
    protected override List<Player> LoadPlayers()
    {
        string LoadPath = FilePath + "Players.xml";
        if (File.Exists( LoadPath ) )
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof( List<Player> ));
                using FileStream fileStream = File.OpenRead( LoadPath );
                return (List<Player>)xmlSerializer.Deserialize( fileStream );
            }
            catch (Exception e)
            {
                return new List<Player>();
            }
        }
        return new List<Player>();
    }

    /// <summary>
    /// Load all highscores from xml file
    /// </summary>
    /// <returns></returns>
    protected override List<Highscore> LoadHighscores()
    {
        string LoadPath = FilePath + "Highscore.xml";
        if (File.Exists( LoadPath ) )
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof( List<Highscore> ));
                using FileStream fileStream = File.OpenRead( LoadPath );
                return (List<Highscore>)xmlSerializer.Deserialize( fileStream );
            }
            catch (Exception e)
            {
                return new List<Highscore>();
            }
        }
        return new List<Highscore>();
    }
}