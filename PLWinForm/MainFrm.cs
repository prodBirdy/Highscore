using BL;using DTO;using PLWinForm;namespace HighScoreGUI;public partial class MainFrm : Form{    private readonly Uow uow;    public MainFrm()    {        InitializeComponent();
        uow = new Uow(DALType.Json);        var players = uow.Players.GetPlayers();        var games = uow.Games.GetGames();        var highscoresPerPlayer = uow.Highscores.GetHighscoresByPlayer(1);        var highscoresPerGame = uow.Highscores.GetHighscoresByGame(1);        dtgPlayers.DataSource = players;        dtgGames.DataSource = games;        dtgHighscoresPlayer.DataSource = highscoresPerPlayer;        dtgHighscoresGame.DataSource = highscoresPerGame;



    }
    private void MainFrm_Load(object sender, EventArgs e)
    {

    }

    private void btnDetailsPlayer_Click(object sender, EventArgs e)
    {
        var playerIndex = (PlayerIndex)dtgPlayers.CurrentRow.DataBoundItem;
        var player = uow.Players.GetPlayer(playerIndex.PlayerId);
        var playerForm = new PlayerForm(WindowType.View, player);
        playerForm.ShowDialog();
    }

    private void dtgGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

}