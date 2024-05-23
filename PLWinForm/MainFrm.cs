using BL;using DTO;using Models;using PLWinForm;using System.Numerics;using static System.ComponentModel.Design.ObjectSelectorEditor;namespace HighScoreGUI;public partial class MainFrm : Form{    public readonly Uow uow;    public MainFrm()    {        InitializeComponent();
        uow = new Uow(DALType.Json);        var players = uow.Players.GetPlayers();        var games = uow.Games.GetGames();        var highscoresPerPlayer = uow.Highscores.GetHighscoresByPlayer(1);        var highscoresPerGame = uow.Highscores.GetHighscoresByGame(1);        playerIndexBindingSource1.DataSource = players;        gameIndexBindingSource1.DataSource = games;        highscorePlayerIndexBindingSource1.DataSource = highscoresPerPlayer;        highscoreGameIndexBindingSource1.DataSource = highscoresPerGame;
        playerIndexBindingSource1.CurrentChanged += PlayerIndexBindingSource_CurrentChanged;
        gameIndexBindingSource1.CurrentChanged += GameIndexBindingSource_CurrentChanged;

    }
    private void ReloadPlayers()
    {
        playerIndexBindingSource1.CurrentChanged -= PlayerIndexBindingSource_CurrentChanged!;
        playerIndexBindingSource1.DataSource = uow.Players.GetPlayers();
        playerIndexBindingSource1.CurrentChanged += PlayerIndexBindingSource_CurrentChanged!;
        var currentPlayer = (PlayerIndex)playerIndexBindingSource1.Current;
        highscorePlayerIndexBindingSource1.DataSource = uow.Highscores.GetHighscoresByPlayer(currentPlayer.PlayerId);
    }

    private void ReloadGames()
    {
        gameIndexBindingSource1.CurrentChanged -= GameIndexBindingSource_CurrentChanged!;
        gameIndexBindingSource1.DataSource = uow.Games.GetGames();
        gameIndexBindingSource1.CurrentChanged += GameIndexBindingSource_CurrentChanged!;
        var currentGame = (GameIndex)gameIndexBindingSource1.Current;
        highscoreGameIndexBindingSource1.DataSource = uow.Highscores.GetHighscoresByGame(currentGame.GameId);
    }
    private void ReloadAll()
    {
        playerIndexBindingSource1.CurrentChanged -= PlayerIndexBindingSource_CurrentChanged!;
        playerIndexBindingSource1.DataSource = uow.Players.GetPlayers();
        playerIndexBindingSource1.CurrentChanged += PlayerIndexBindingSource_CurrentChanged!;
        gameIndexBindingSource1.CurrentChanged -= GameIndexBindingSource_CurrentChanged!;
        gameIndexBindingSource1.DataSource = uow.Games.GetGames();
        gameIndexBindingSource1.CurrentChanged += GameIndexBindingSource_CurrentChanged!;
        var player = (PlayerIndex)dtgPlayers.CurrentRow.DataBoundItem;
        var game = (GameIndex)dtgGames.CurrentRow.DataBoundItem;
        highscorePlayerIndexBindingSource1.DataSource = uow.Highscores.GetHighscoresByPlayer(player.PlayerId );
        highscoreGameIndexBindingSource1.DataSource = uow.Highscores.GetHighscoresByGame(game.GameId);
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

    public delegate void UpdatePlayerDelegate(PlayerDetail playerDetail);

    private void UpdatePlayer(PlayerDetail playerDetail)
    {
        if (uow.Players.Update(playerDetail))
            MessageBox.Show($@"Updated Successfully {playerDetail.FName} {playerDetail.LName}");
    }

    public delegate void AddPlayerDelegate(PlayerAdd playerAdd);
    private void AddPlayer(PlayerAdd player)
    {
        if (uow.Players.Add(player))
            MessageBox.Show($@"Added Successfully {player.FName} {player.LName}");
    }
    private void btnAddPlayer_Click(object sender, EventArgs e)
    {
        var playerForm = new PlayerForm(WindowType.Add);
        playerForm.AddPlayer = new AddPlayerDelegate(this.AddPlayer);
        playerForm.ShowDialog();

        ReloadPlayers();
    }

    private void btnDeletePlayer_Click(object sender, EventArgs e)
    {
        var currentPlayer = (PlayerIndex)playerIndexBindingSource1.Current;
        var sureResult = MessageBox.Show($@"Are u sure u want do delete {currentPlayer.FullName}?");

        if (sureResult == DialogResult.OK)
            uow.Players.Delete(currentPlayer.PlayerId);

        ReloadPlayers();
    }

    private void btnDetailsGame_Click(object sender, EventArgs e)
    {
        var gameIndex = (GameIndex)dtgGames.CurrentRow.DataBoundItem;
        var game = uow.Games.GetGame(gameIndex.GameId);
        var gameForm = new GameForm(WindowType.View, game);
        gameForm.ShowDialog();
    }


    public delegate void AddGameDelegate(GameDetail gameDetail);

    private void AddGame(GameDetail gameDetail)
    {
        if (uow.Games.Add(gameDetail))
            MessageBox.Show($@"Added Successfully {gameDetail.Title}");
    }

    private void btnAddGame_Click(object sender, EventArgs e)
    {
        var gameForm = new GameForm(WindowType.Add);
        gameForm.AddGame = new AddGameDelegate(this.AddGame);

        gameForm.ShowDialog();

        ReloadGames();
    }

    private void btnDeleteGame_Click(object sender, EventArgs e)
    {
        var currentGame = (GameIndex)gameIndexBindingSource1.Current;
        var sureResult = MessageBox.Show($@"Are u sure u want do delete {currentGame.Title}?");

        if (sureResult == DialogResult.OK)
            uow.Games.Delete(currentGame.GameId);

        ReloadGames();

    }

    private void btnDetailsHighscorePlayer_Click(object sender, EventArgs e)
    {
        var highscoreIndex = (HighscoreIndex)dtgHighscoresPlayer.CurrentRow.DataBoundItem;
        var highForm = new HighscoreForm(WindowType.View, highscoreIndex);
        highForm.ShowDialog();


    }
    public delegate void UpdateHighScoreDelegate(HighscoreIndex highScore);

    private void UpdateHighScore(HighscoreIndex highScore)
    {
        if (uow.Highscores.Update(highScore))
            MessageBox.Show($@"Updated Successfully HighScore");
    }

    public delegate void AddHighScoreDelegate(HighscoreIndex highScore);

    private void AddHighScore(HighscoreIndex highScore)
    {
        if (uow.Highscores.Add(highScore))
            MessageBox.Show($@"Added Successfully new HighScore");
    }
    private void btnAddHighscorePlayer_Click(object sender, EventArgs e)
    {
        var currentPlayer = (PlayerIndex)playerIndexBindingSource1.Current;
        var selects = uow.Players.GetPlayerSelect();
        var highscore = new HighscoreIndex
        {
            PlayerId = currentPlayer.PlayerId,
            Created = DateTime.Now
        };
        HighscoreForm addHighScoreForm = new HighscoreForm(WindowType.Add, highscore, currentPlayer, null, selects);
        addHighScoreForm.AddHighScore = new AddHighScoreDelegate(this.AddHighScore);

        addHighScoreForm.ShowDialog();

        ReloadAll();
    }

    private void btnDeleteHighscorePlayer_Click(object sender, EventArgs e)
    {
        var currentHighScore = (HighscoreIndex)highscorePlayerIndexBindingSource1.Current;

        var sureResult = MessageBox.Show($@"Are u sure u want do delete HighScore {currentHighScore.Score} from {currentHighScore.Created}?");
        if (sureResult == DialogResult.OK)
            uow.Highscores.Delete(currentHighScore.GameId, currentHighScore.PlayerId);

        ReloadAll();
    }


    private void btnDetailsHighscoreGame_Click(object sender, EventArgs e)
    {
        var highscoreIndex = (HighscoreIndex)dtgHighscoresGame.CurrentRow.DataBoundItem;
        var highForm = new HighscoreForm(WindowType.View, highscoreIndex);
        highForm.ShowDialog();
    }

    private void btnAddHighscoreGame_Click(object sender, EventArgs e)
    {
        var currentGame = (GameIndex)gameIndexBindingSource1.Current;
        var selects = uow.Games.GetGameSelect();
        var highscore = new HighscoreIndex
        {
            GameId = currentGame.GameId,
            Created = DateTime.Now
        };
        HighscoreForm addHighScoreForm = new HighscoreForm(WindowType.Add, highscore, null, currentGame, selects);
        addHighScoreForm.AddHighScore = new AddHighScoreDelegate(this.AddHighScore);

        addHighScoreForm.ShowDialog();

        ReloadAll();
    }

    private void btnDeleteHighscoreGame_Click(object sender, EventArgs e)
    {
        var currentHighScore = (HighscoreIndex)highscoreGameIndexBindingSource1.Current;

        var sureResult = MessageBox.Show($@"Are u sure u want do delete HighScore {currentHighScore.Score} from {currentHighScore.Created}?");
        if (sureResult == DialogResult.OK)
            uow.Highscores.Delete(currentHighScore.GameId, currentHighScore.PlayerId);

        ReloadAll();
    }

    private void dtgPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var playerIndex = (PlayerIndex)dtgPlayers.CurrentRow.DataBoundItem;
        var player = uow.Players.GetPlayer(playerIndex.PlayerId);
        var playerForm = new PlayerForm(WindowType.Edit, player);
        playerForm.UpdatePlayer = new UpdatePlayerDelegate(this.UpdatePlayer);

        playerForm.ShowDialog();

        ReloadAll();
    }
    public delegate void UpdateGameDelegate(GameDetail gameDetail);

    private void UpdateGame(GameDetail gameDetail)
    {
        if (uow.Games.Update(gameDetail))
            MessageBox.Show($@"Updated Successfully {gameDetail.Title}");
    }
    private void dtgGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var gameIndex = (GameIndex)dtgGames.CurrentRow.DataBoundItem;
        var game = uow.Games.GetGame(gameIndex.GameId);
        var gameForm = new GameForm(WindowType.Edit, game);
        gameForm.UpdateGame = new UpdateGameDelegate(this.UpdateGame);

        gameForm.ShowDialog();

        ReloadAll();
    }


    private void dtgHighscoresGame_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var game = (GameIndex)dtgGames.CurrentRow.DataBoundItem;
        var highscoreIndex = uow.Highscores.GetHighscoresByGame(game.GameId).Find(h => h.GameId  == (int)dtgHighscoresGame[0 , e.RowIndex].Value);
        var selects = uow.Games.GetGameSelect();

        HighscoreForm addHighScoreForm = new HighscoreForm(WindowType.Edit, highscoreIndex, null, game, selects);
        addHighScoreForm.UpdateHighScore = new UpdateHighScoreDelegate(this.UpdateHighScore);

        addHighScoreForm.ShowDialog();

        ReloadAll();
    }

    private void dtgHighscoresPlayer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        //TODO Check bug in Update Function
        var player = (PlayerIndex)dtgPlayers.CurrentRow.DataBoundItem;
        var highscoreIndex = uow.Highscores.GetHighscoresByPlayer(player.PlayerId).Find(h => h.PlayerId == (int)dtgHighscoresPlayer[0, e.RowIndex].Value);

        var selects = uow.Players.GetPlayerSelect();

        HighscoreForm addHighScoreForm = new HighscoreForm(WindowType.Edit, highscoreIndex, player, null, selects);
        addHighScoreForm.UpdateHighScore = new UpdateHighScoreDelegate(this.UpdateHighScore);

        addHighScoreForm.ShowDialog();

        ReloadAll();
    }


    private void btnSave_Click(object sender, EventArgs e)
    {
        uow.Commit();
    }

    private void btnRollback_Click(object sender, EventArgs e)
    {
        var sureResult = MessageBox.Show($@"Are u sure u want do rollback?");

        if (sureResult == DialogResult.OK)
        {
            uow.Rollback();
            ReloadAll();
        }
    }


}