using BL;
        uow = new Uow(DALType.Json);



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