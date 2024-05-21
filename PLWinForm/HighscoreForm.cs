using DTO;
using HighScoreGUI;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PLWinForm
{
    public partial class HighscoreForm : Form
    {
        private List<PlayerIndex> players;
        private List<GameIndex> games;
        public HighscoreForm(WindowType window, List < GameIndex> gameIndexDataSource, List<PlayerIndex> playerIndexDataSource)
        {
            InitializeComponent();
            players = playerIndexDataSource;
            games = gameIndexDataSource;

            PlayerIndexBindingSource.DataSource = playerIndexDataSource.Select(player => player.FullName);
            GameIndexBindingSource.DataSource = gameIndexDataSource.Select(game => game.Title);
        }

        public HighscoreForm(WindowType windwo, HighscoreIndex h)
        {
            InitializeComponent();
        }


        public MainFrm.AddHighScoreDelegate AddHighScore = delegate { };

        private void addHighScoreButton_Click(object sender, EventArgs e)
        {
            var player = players.Find(player => player.FullName == (string)PlayerIndexBindingSource.Current);
            var game = games.Find(game => game.Title == (string)GameIndexBindingSource.Current);

            AddHighScore(new Highscore
            {
                PlayerId = player!.PlayerId,
                GameId = game!.GameId,
                Score = Decimal.ToInt32(scoreInput.Value),
                Created = DateTime.Now,
            });

            this.Close();
        }
    }
}
