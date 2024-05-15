using BL;using DTO;using PLWinForm;namespace HighScoreGUI;public partial class MainFrm : Form{    public readonly Uow uow;    public MainFrm()    {        InitializeComponent();
        uow = new Uow(DALType.Json);        var players = uow.Players.GetPlayers();        var games = uow.Games.GetGames();        var highscoresPerPlayer = uow.Highscores.GetHighscoresByPlayer(1);        var highscoresPerGame = uow.Highscores.GetHighscoresByGame(1);        playerIndexBindingSource1.DataSource = players;        gameIndexBindingSource1.DataSource = games;        highscorePlayerIndexBindingSource1.DataSource = highscoresPerPlayer;        highscoreGameIndexBindingSource1.DataSource = highscoresPerGame;

        playerIndexBindingSource1.CurrentChanged += PlayerIndexBindingSource_CurrentChanged;

        gameIndexBindingSource1.CurrentChanged += GameIndexBindingSource_CurrentChanged;


    }

    private void PlayerIndexBindingSource_CurrentChanged(object? sender, EventArgs e)
    {
        try
        {
            PlayerIndex pi = (PlayerIndex)playerIndexBindingSource1.Current;
            highscorePlayerIndexBindingSource1.DataSource = uow.Highscores.GetHighscoresByPlayer(pi.PlayerId);
        }
        catch (Exception)
        {


        }

    }
    private void GameIndexBindingSource_CurrentChanged(object? sender, EventArgs e)
    {

        try
        {
            GameIndex gi = (GameIndex)gameIndexBindingSource1.Current;
            highscoreGameIndexBindingSource1.DataSource = uow.Highscores.GetHighscoresByPlayer(gi.GameId);
        }
        catch (Exception)
        {


        }
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

    private void btnAddPlayer_Click(object sender, EventArgs e)
    {
        var playerForm = new PlayerForm(WindowType.Add);
        playerForm.ShowDialog();
    }

    private void btnDeletePlayer_Click(object sender, EventArgs e)
    {

    }

    private void btnDetailsGame_Click(object sender, EventArgs e)
    {

    }

    private void btnAddGame_Click(object sender, EventArgs e)
    {

    }

    private void btnDeleteGame_Click(object sender, EventArgs e)
    {

    }

    private void btnDetailsHighscorePlayer_Click(object sender, EventArgs e)
    {

    }

    private void btnAddHighscorePlayer_Click(object sender, EventArgs e)
    {

    }

    private void btnDeleteHighscorePlayer_Click(object sender, EventArgs e)
    {

    }

    private void btnDetailsHighscoreGame_Click(object sender, EventArgs e)
    {

    }

    private void btnAddHighscoreGame_Click(object sender, EventArgs e)
    {

    }

    private void btnDeleteHighscoreGame_Click(object sender, EventArgs e)
    {

    }

    private void dtgPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var playerIndex = (PlayerIndex)dtgPlayers.CurrentRow.DataBoundItem;
        var player = uow.Players.GetPlayer(playerIndex.PlayerId);
        var playerForm = new PlayerForm(WindowType.Edit, player);
        playerForm.ShowDialog();
    }

    private void dtgGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}