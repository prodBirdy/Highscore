namespace HighScoreGUI
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            dtgPlayers = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            playerIndexBindingSource1 = new BindingSource(components);
            playerIndexBindingSource = new BindingSource(components);
            dtgGames = new DataGridView();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            releaseDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gameIndexBindingSource1 = new BindingSource(components);
            gameIndexBindingSource = new BindingSource(components);
            dtgHighscoresPlayer = new DataGridView();
            playerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scoreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            highscorePlayerIndexBindingSource1 = new BindingSource(components);
            highscorePlayerIndexBindingSource = new BindingSource(components);
            dtgHighscoresGame = new DataGridView();
            gameIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scoreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            createdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            highscoreGameIndexBindingSource1 = new BindingSource(components);
            highscoreGameIndexBindingSource = new BindingSource(components);
            btnDetailsPlayer = new Button();
            btnAddPlayer = new Button();
            btnDeletePlayer = new Button();
            btnDeleteGame = new Button();
            btnAddGame = new Button();
            btnDetailsGame = new Button();
            btnDeleteHighscorePlayer = new Button();
            btnAddHighscorePlayer = new Button();
            btnDetailsHighscorePlayer = new Button();
            btnDeleteHighscoreGame = new Button();
            btnAddHighscoreGame = new Button();
            btnDetailsHighscoreGame = new Button();
            btnRollback = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highscorePlayerIndexBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highscorePlayerIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highscoreGameIndexBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highscoreGameIndexBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1116, 9);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 367);
            textBox1.TabIndex = 4;
            // 
            // dtgPlayers
            // 
            dtgPlayers.AutoGenerateColumns = false;
            dtgPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPlayers.BackgroundColor = SystemColors.Control;
            dtgPlayers.BorderStyle = BorderStyle.None;
            dtgPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPlayers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn11 });
            dtgPlayers.DataSource = playerIndexBindingSource1;
            dtgPlayers.Location = new Point(11, 9);
            dtgPlayers.Margin = new Padding(3, 2, 3, 2);
            dtgPlayers.Name = "dtgPlayers";
            dtgPlayers.RowHeadersWidth = 51;
            dtgPlayers.RowTemplate.Height = 29;
            dtgPlayers.Size = new Size(503, 201);
            dtgPlayers.TabIndex = 5;
            dtgPlayers.CellDoubleClick += dtgPlayers_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "PlayerId";
            dataGridViewTextBoxColumn6.HeaderText = "PlayerId";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "FullName";
            dataGridViewTextBoxColumn7.HeaderText = "FullName";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "BirthDay";
            dataGridViewTextBoxColumn11.HeaderText = "BirthDay";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // playerIndexBindingSource1
            // 
            playerIndexBindingSource1.DataSource = typeof(DTO.PlayerIndex);
            // 
            // dtgGames
            // 
            dtgGames.AutoGenerateColumns = false;
            dtgGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgGames.BackgroundColor = SystemColors.Control;
            dtgGames.BorderStyle = BorderStyle.None;
            dtgGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGames.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, releaseDateDataGridViewTextBoxColumn });
            dtgGames.DataSource = gameIndexBindingSource1;
            dtgGames.Location = new Point(567, 9);
            dtgGames.Margin = new Padding(3, 2, 3, 2);
            dtgGames.Name = "dtgGames";
            dtgGames.RowHeadersWidth = 51;
            dtgGames.RowTemplate.Height = 29;
            dtgGames.Size = new Size(503, 201);
            dtgGames.TabIndex = 6;
            dtgGames.CellDoubleClick += dtgGames_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "GameId";
            dataGridViewTextBoxColumn12.HeaderText = "GameId";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Title";
            dataGridViewTextBoxColumn13.HeaderText = "Title";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            // 
            // gameIndexBindingSource1
            // 
            gameIndexBindingSource1.DataSource = typeof(DTO.GameIndex);
            // 
            // dtgHighscoresPlayer
            // 
            dtgHighscoresPlayer.AutoGenerateColumns = false;
            dtgHighscoresPlayer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHighscoresPlayer.BackgroundColor = SystemColors.Control;
            dtgHighscoresPlayer.BorderStyle = BorderStyle.None;
            dtgHighscoresPlayer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHighscoresPlayer.Columns.AddRange(new DataGridViewColumn[] { playerIdDataGridViewTextBoxColumn, scoreDataGridViewTextBoxColumn, createdDataGridViewTextBoxColumn });
            dtgHighscoresPlayer.DataSource = highscorePlayerIndexBindingSource1;
            dtgHighscoresPlayer.Location = new Point(11, 275);
            dtgHighscoresPlayer.Margin = new Padding(3, 2, 3, 2);
            dtgHighscoresPlayer.Name = "dtgHighscoresPlayer";
            dtgHighscoresPlayer.RowHeadersWidth = 51;
            dtgHighscoresPlayer.RowTemplate.Height = 29;
            dtgHighscoresPlayer.Size = new Size(503, 182);
            dtgHighscoresPlayer.TabIndex = 7;
            dtgHighscoresPlayer.CellDoubleClick += dtgHighscoresPlayer_CellDoubleClick;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
            playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // createdDataGridViewTextBoxColumn
            // 
            createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            createdDataGridViewTextBoxColumn.HeaderText = "Created";
            createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            // 
            // highscorePlayerIndexBindingSource1
            // 
            highscorePlayerIndexBindingSource1.DataSource = typeof(DTO.HighscorePlayerIndex);
            // 
            // dtgHighscoresGame
            // 
            dtgHighscoresGame.AutoGenerateColumns = false;
            dtgHighscoresGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHighscoresGame.BackgroundColor = SystemColors.Control;
            dtgHighscoresGame.BorderStyle = BorderStyle.None;
            dtgHighscoresGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHighscoresGame.Columns.AddRange(new DataGridViewColumn[] { gameIdDataGridViewTextBoxColumn, scoreDataGridViewTextBoxColumn1, createdDataGridViewTextBoxColumn1 });
            dtgHighscoresGame.DataSource = highscoreGameIndexBindingSource1;
            dtgHighscoresGame.Location = new Point(567, 275);
            dtgHighscoresGame.Margin = new Padding(3, 2, 3, 2);
            dtgHighscoresGame.Name = "dtgHighscoresGame";
            dtgHighscoresGame.RowHeadersWidth = 51;
            dtgHighscoresGame.RowTemplate.Height = 29;
            dtgHighscoresGame.Size = new Size(503, 182);
            dtgHighscoresGame.TabIndex = 8;
            dtgHighscoresGame.CellDoubleClick += dtgHighscoresGame_CellDoubleClick;
            // 
            // gameIdDataGridViewTextBoxColumn
            // 
            gameIdDataGridViewTextBoxColumn.DataPropertyName = "GameId";
            gameIdDataGridViewTextBoxColumn.HeaderText = "GameId";
            gameIdDataGridViewTextBoxColumn.Name = "gameIdDataGridViewTextBoxColumn";
            gameIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // scoreDataGridViewTextBoxColumn1
            // 
            scoreDataGridViewTextBoxColumn1.DataPropertyName = "Score";
            scoreDataGridViewTextBoxColumn1.HeaderText = "Score";
            scoreDataGridViewTextBoxColumn1.Name = "scoreDataGridViewTextBoxColumn1";
            // 
            // createdDataGridViewTextBoxColumn1
            // 
            createdDataGridViewTextBoxColumn1.DataPropertyName = "Created";
            createdDataGridViewTextBoxColumn1.HeaderText = "Created";
            createdDataGridViewTextBoxColumn1.Name = "createdDataGridViewTextBoxColumn1";
            // 
            // highscoreGameIndexBindingSource1
            // 
            highscoreGameIndexBindingSource1.DataSource = typeof(DTO.HighscoreGameIndex);
            // 
            // btnDetailsPlayer
            // 
            btnDetailsPlayer.Location = new Point(11, 215);
            btnDetailsPlayer.Margin = new Padding(3, 2, 3, 2);
            btnDetailsPlayer.Name = "btnDetailsPlayer";
            btnDetailsPlayer.Size = new Size(82, 22);
            btnDetailsPlayer.TabIndex = 9;
            btnDetailsPlayer.Text = "Details";
            btnDetailsPlayer.UseVisualStyleBackColor = true;
            btnDetailsPlayer.Click += btnDetailsPlayer_Click;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(326, 215);
            btnAddPlayer.Margin = new Padding(3, 2, 3, 2);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(82, 22);
            btnAddPlayer.TabIndex = 10;
            btnAddPlayer.Text = "Add";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.Location = new Point(414, 215);
            btnDeletePlayer.Margin = new Padding(3, 2, 3, 2);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Size = new Size(82, 22);
            btnDeletePlayer.TabIndex = 11;
            btnDeletePlayer.Text = "Delete";
            btnDeletePlayer.UseVisualStyleBackColor = true;
            btnDeletePlayer.Click += btnDeletePlayer_Click;
            // 
            // btnDeleteGame
            // 
            btnDeleteGame.Location = new Point(970, 215);
            btnDeleteGame.Margin = new Padding(3, 2, 3, 2);
            btnDeleteGame.Name = "btnDeleteGame";
            btnDeleteGame.Size = new Size(82, 22);
            btnDeleteGame.TabIndex = 14;
            btnDeleteGame.Text = "Delete";
            btnDeleteGame.UseVisualStyleBackColor = true;
            btnDeleteGame.Click += btnDeleteGame_Click;
            // 
            // btnAddGame
            // 
            btnAddGame.Location = new Point(883, 215);
            btnAddGame.Margin = new Padding(3, 2, 3, 2);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(82, 22);
            btnAddGame.TabIndex = 13;
            btnAddGame.Text = "Add";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // btnDetailsGame
            // 
            btnDetailsGame.Location = new Point(567, 215);
            btnDetailsGame.Margin = new Padding(3, 2, 3, 2);
            btnDetailsGame.Name = "btnDetailsGame";
            btnDetailsGame.Size = new Size(82, 22);
            btnDetailsGame.TabIndex = 12;
            btnDetailsGame.Text = "Details";
            btnDetailsGame.UseVisualStyleBackColor = true;
            btnDetailsGame.Click += btnDetailsGame_Click;
            // 
            // btnDeleteHighscorePlayer
            // 
            btnDeleteHighscorePlayer.Location = new Point(431, 461);
            btnDeleteHighscorePlayer.Margin = new Padding(3, 2, 3, 2);
            btnDeleteHighscorePlayer.Name = "btnDeleteHighscorePlayer";
            btnDeleteHighscorePlayer.Size = new Size(82, 22);
            btnDeleteHighscorePlayer.TabIndex = 17;
            btnDeleteHighscorePlayer.Text = "Delete";
            btnDeleteHighscorePlayer.UseVisualStyleBackColor = true;
            btnDeleteHighscorePlayer.Click += btnDeleteHighscorePlayer_Click;
            // 
            // btnAddHighscorePlayer
            // 
            btnAddHighscorePlayer.Location = new Point(344, 461);
            btnAddHighscorePlayer.Margin = new Padding(3, 2, 3, 2);
            btnAddHighscorePlayer.Name = "btnAddHighscorePlayer";
            btnAddHighscorePlayer.Size = new Size(82, 22);
            btnAddHighscorePlayer.TabIndex = 16;
            btnAddHighscorePlayer.Text = "Add";
            btnAddHighscorePlayer.UseVisualStyleBackColor = true;
            btnAddHighscorePlayer.Click += btnAddHighscorePlayer_Click;
            // 
            // btnDetailsHighscorePlayer
            // 
            btnDetailsHighscorePlayer.Location = new Point(11, 461);
            btnDetailsHighscorePlayer.Margin = new Padding(3, 2, 3, 2);
            btnDetailsHighscorePlayer.Name = "btnDetailsHighscorePlayer";
            btnDetailsHighscorePlayer.Size = new Size(82, 22);
            btnDetailsHighscorePlayer.TabIndex = 15;
            btnDetailsHighscorePlayer.Text = "Details";
            btnDetailsHighscorePlayer.UseVisualStyleBackColor = true;
            btnDetailsHighscorePlayer.Click += btnDetailsHighscorePlayer_Click;
            // 
            // btnDeleteHighscoreGame
            // 
            btnDeleteHighscoreGame.Location = new Point(988, 461);
            btnDeleteHighscoreGame.Margin = new Padding(3, 2, 3, 2);
            btnDeleteHighscoreGame.Name = "btnDeleteHighscoreGame";
            btnDeleteHighscoreGame.Size = new Size(82, 22);
            btnDeleteHighscoreGame.TabIndex = 20;
            btnDeleteHighscoreGame.Text = "Delete";
            btnDeleteHighscoreGame.UseVisualStyleBackColor = true;
            btnDeleteHighscoreGame.Click += btnDeleteHighscoreGame_Click;
            // 
            // btnAddHighscoreGame
            // 
            btnAddHighscoreGame.Location = new Point(900, 461);
            btnAddHighscoreGame.Margin = new Padding(3, 2, 3, 2);
            btnAddHighscoreGame.Name = "btnAddHighscoreGame";
            btnAddHighscoreGame.Size = new Size(82, 22);
            btnAddHighscoreGame.TabIndex = 19;
            btnAddHighscoreGame.Text = "Add";
            btnAddHighscoreGame.UseVisualStyleBackColor = true;
            btnAddHighscoreGame.Click += btnAddHighscoreGame_Click;
            // 
            // btnDetailsHighscoreGame
            // 
            btnDetailsHighscoreGame.Location = new Point(567, 461);
            btnDetailsHighscoreGame.Margin = new Padding(3, 2, 3, 2);
            btnDetailsHighscoreGame.Name = "btnDetailsHighscoreGame";
            btnDetailsHighscoreGame.Size = new Size(82, 22);
            btnDetailsHighscoreGame.TabIndex = 18;
            btnDetailsHighscoreGame.Text = "Details";
            btnDetailsHighscoreGame.UseVisualStyleBackColor = true;
            btnDetailsHighscoreGame.Click += btnDetailsHighscoreGame_Click;
            // 
            // btnRollback
            // 
            btnRollback.Location = new Point(1116, 380);
            btnRollback.Margin = new Padding(3, 2, 3, 2);
            btnRollback.Name = "btnRollback";
            btnRollback.Size = new Size(162, 50);
            btnRollback.TabIndex = 21;
            btnRollback.Text = "Rollback";
            btnRollback.UseVisualStyleBackColor = true;
            btnRollback.Click += btnRollback_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1116, 434);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 50);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 492);
            Controls.Add(btnSave);
            Controls.Add(btnRollback);
            Controls.Add(btnDeleteHighscoreGame);
            Controls.Add(btnAddHighscoreGame);
            Controls.Add(btnDetailsHighscoreGame);
            Controls.Add(btnDeleteHighscorePlayer);
            Controls.Add(btnAddHighscorePlayer);
            Controls.Add(btnDetailsHighscorePlayer);
            Controls.Add(btnDeleteGame);
            Controls.Add(btnAddGame);
            Controls.Add(btnDetailsGame);
            Controls.Add(btnDeletePlayer);
            Controls.Add(btnAddPlayer);
            Controls.Add(btnDetailsPlayer);
            Controls.Add(dtgHighscoresGame);
            Controls.Add(dtgHighscoresPlayer);
            Controls.Add(dtgGames);
            Controls.Add(dtgPlayers);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainFrm";
            Text = "Highscores";
            Load += MainFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)highscorePlayerIndexBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)highscorePlayerIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)highscoreGameIndexBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)highscoreGameIndexBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dtgPlayers;
        private DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridView dtgGames;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridView dtgHighscoresPlayer;
        private DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn scoreDateDataGridViewTextBoxColumn;
        private DataGridView dtgHighscoresGame;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnDetailsPlayer;
        private Button btnAddPlayer;
        private Button btnDeletePlayer;
        private Button btnDeleteGame;
        private Button btnAddGame;
        private Button btnDetailsGame;
        private Button btnDeleteHighscorePlayer;
        private Button btnAddHighscorePlayer;
        private Button btnDetailsHighscorePlayer;
        private Button btnDeleteHighscoreGame;
        private Button btnAddHighscoreGame;
        private Button btnDetailsHighscoreGame;
        private Button btnRollback;
        private Button btnSave;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private BindingSource playerIndexBindingSource;
        private BindingSource gameIndexBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BindingSource highscoreGameIndexBindingSource;
        private DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private BindingSource highscorePlayerIndexBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn1;
        private BindingSource playerIndexBindingSource1;
        private BindingSource gameIndexBindingSource1;
        private BindingSource highscorePlayerIndexBindingSource1;
        private BindingSource highscoreGameIndexBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn1;
    }
}

namespace HighScoreModels
{
    class ViewModels
    {
        internal class PlayerViewModel
        {
        }

        internal class GameViewModel
        {
        }
    }
}