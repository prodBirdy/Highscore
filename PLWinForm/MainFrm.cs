using BL;namespace HighScoreGUI;public partial class MainFrm : Form{    private readonly Uow unitOfWork;    public MainFrm()    {        InitializeComponent();
        var uow = new Uow(DALType.Json);        var players = uow.Players.GetPlayers();        var games = uow.Games.GetGames();        var highscoresPerPlayer = uow.Highscores.GetHighscoresByPlayer(1);        var highscoresPerGame = uow.Highscores.GetHighscoresByGame(1);        dtgPlayers.DataSource = players;        dtgGames.DataSource = games;        dtgHighscoresPlayer.DataSource = highscoresPerPlayer;        dtgHighscoresGame.DataSource = highscoresPerGame;

    }    private void dtgPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)    {    }

    private void MainFrm_Load(object sender, EventArgs e)
    {

    }

    private void btnDetailsPlayer_Click(object sender, EventArgs e)
    {

    }

    private void highScoreBindingSource1_CurrentChanged(object sender, EventArgs e)
    {

    }

    private void dtgGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}