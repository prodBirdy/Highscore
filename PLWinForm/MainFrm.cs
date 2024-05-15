using BL;

namespace HighScoreGUI;

public partial class MainFrm : Form
{
    private readonly Uow unitOfWork;

    public MainFrm()
    {
        InitializeComponent();

        DALType filetyp = "Json";
        uow = new Uow();

        var players = uow.PlayersRepo.GetAllPlayers();
        var games = uow.GamesRepo.GetAllGames();
        var highscoresPerPlayer = uow.HighScoresRepo.GetAllHighScoreByPlayerId(1);
        var highscoresPerGame = uow.HighScoresRepo.GetAllHighScoreByGameId(1);

        dtgPlayers.DataSource = players;
        dtgGames.DataSource = games;
        dtgHighscoresPlayer.DataSource = highscoresPerPlayer;
        dtgHighscoresGame.DataSource = highscoresPerGame;
    }
}