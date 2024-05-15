using BL;using DTO;using PLWinForm;namespace HighScoreGUI;public partial class MainFrm : Form{    private readonly Uow uow;    public MainFrm()    {        InitializeComponent();
        uow = new Uow(DALType.Json);        var players = uow.Players.GetPlayers();        var games = uow.Games.GetGames();        var highscoresPerPlayer = uow.Highscores.GetHighscoresByPlayer(1);        var highscoresPerGame = uow.Highscores.GetHighscoresByGame(1);        playerIndexBindingSource.DataSource = players;        gameIndexBindingSource.DataSource = games;        highscorePlayerIndexBindingSource.DataSource = highscoresPerPlayer;        highscoreGameIndexBindingSource.DataSource = highscoresPerGame;

        playerIndexBindingSource.CurrentChanged += PlayerIndexBindingSource_CurrentChanged;

        gameIndexBindingSource.CurrentChanged += GameIndexBindingSource_CurrentChanged;

        PlayerIndexBindingSource_CurrentChanged(null, null);
        GameIndexBindingSource_CurrentChanged(null, null);
    }

    private void PlayerIndexBindingSource_CurrentChanged(object? sender, EventArgs e)
    {
        PlayerIndex pi = (PlayerIndex)playerIndexBindingSource.Current;
        highscorePlayerIndexBindingSource.DataSource = uow.Highscores.GetHighscoresByPlayer(pi.PlayerId);
    }
    private void GameIndexBindingSource_CurrentChanged(object? sender, EventArgs e)
    {
        GameIndex gi = (GameIndex)gameIndexBindingSource.Current;
        highscoreGameIndexBindingSource.DataSource = uow.Highscores.GetHighscoresByPlayer(gi.GameId);
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