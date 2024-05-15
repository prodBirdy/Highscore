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
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            playerIndexBindingSource = new BindingSource(components);
            dtgGames = new DataGridView();
            playerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scoreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dtgHighscoresPlayer = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            releaseDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gameIndexBindingSource = new BindingSource(components);
            dtgHighscoresGame = new DataGridView();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            scoreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            createdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
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
            highscorePlayerIndexBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dtgPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highscoreGameIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highscorePlayerIndexBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2072, 19);
            textBox1.Margin = new Padding(5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 778);
            textBox1.TabIndex = 4;
            // 
            // dtgPlayers
            // 
            dtgPlayers.AutoGenerateColumns = false;
            dtgPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPlayers.BackgroundColor = SystemColors.Control;
            dtgPlayers.BorderStyle = BorderStyle.None;
            dtgPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPlayers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, fullNameDataGridViewTextBoxColumn, birthDayDataGridViewTextBoxColumn });
            dtgPlayers.DataSource = playerIndexBindingSource;
            dtgPlayers.Location = new Point(20, 19);
            dtgPlayers.Margin = new Padding(5);
            dtgPlayers.Name = "dtgPlayers";
            dtgPlayers.RowHeadersWidth = 51;
            dtgPlayers.RowTemplate.Height = 29;
            dtgPlayers.Size = new Size(934, 429);
            dtgPlayers.TabIndex = 5;
            dtgPlayers.CellContentClick += dtgPlayers_CellContentClick;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "PlayerId";
            dataGridViewTextBoxColumn5.HeaderText = "PlayerId";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            birthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay";
            birthDayDataGridViewTextBoxColumn.MinimumWidth = 10;
            birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            // 
            // playerIndexBindingSource
            // 
            playerIndexBindingSource.DataSource = typeof(DTO.PlayerIndex);
            // 
            // dtgGames
            // 
            dtgGames.AutoGenerateColumns = false;
            dtgGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgGames.BackgroundColor = SystemColors.Control;
            dtgGames.BorderStyle = BorderStyle.None;
            dtgGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGames.Columns.AddRange(new DataGridViewColumn[] { playerIdDataGridViewTextBoxColumn, scoreDataGridViewTextBoxColumn, createdDataGridViewTextBoxColumn });
            dtgGames.DataSource = highscorePlayerIndexBindingSource;
            dtgGames.Location = new Point(1053, 19);
            dtgGames.Margin = new Padding(5);
            dtgGames.Name = "dtgGames";
            dtgGames.RowHeadersWidth = 51;
            dtgGames.RowTemplate.Height = 29;
            dtgGames.Size = new Size(934, 429);
            dtgGames.TabIndex = 6;
            dtgGames.CellContentClick += dtgGames_CellContentClick;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
            playerIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            scoreDataGridViewTextBoxColumn.MinimumWidth = 10;
            scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // createdDataGridViewTextBoxColumn
            // 
            createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            createdDataGridViewTextBoxColumn.HeaderText = "Created";
            createdDataGridViewTextBoxColumn.MinimumWidth = 10;
            createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            // 
            // dtgHighscoresPlayer
            // 
            dtgHighscoresPlayer.AutoGenerateColumns = false;
            dtgHighscoresPlayer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHighscoresPlayer.BackgroundColor = SystemColors.Control;
            dtgHighscoresPlayer.BorderStyle = BorderStyle.None;
            dtgHighscoresPlayer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHighscoresPlayer.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, releaseDateDataGridViewTextBoxColumn });
            dtgHighscoresPlayer.DataSource = gameIndexBindingSource;
            dtgHighscoresPlayer.Location = new Point(20, 586);
            dtgHighscoresPlayer.Margin = new Padding(5);
            dtgHighscoresPlayer.Name = "dtgHighscoresPlayer";
            dtgHighscoresPlayer.RowHeadersWidth = 51;
            dtgHighscoresPlayer.RowTemplate.Height = 29;
            dtgHighscoresPlayer.Size = new Size(934, 389);
            dtgHighscoresPlayer.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "GameId";
            dataGridViewTextBoxColumn6.HeaderText = "GameId";
            dataGridViewTextBoxColumn6.MinimumWidth = 10;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Title";
            dataGridViewTextBoxColumn7.HeaderText = "Title";
            dataGridViewTextBoxColumn7.MinimumWidth = 10;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            releaseDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            // 
            // gameIndexBindingSource
            // 
            gameIndexBindingSource.DataSource = typeof(DTO.GameIndex);
            // 
            // dtgHighscoresGame
            // 
            dtgHighscoresGame.AutoGenerateColumns = false;
            dtgHighscoresGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHighscoresGame.BackgroundColor = SystemColors.Control;
            dtgHighscoresGame.BorderStyle = BorderStyle.None;
            dtgHighscoresGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHighscoresGame.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, scoreDataGridViewTextBoxColumn1, createdDataGridViewTextBoxColumn1 });
            dtgHighscoresGame.DataSource = highscoreGameIndexBindingSource;
            dtgHighscoresGame.Location = new Point(1053, 586);
            dtgHighscoresGame.Margin = new Padding(5);
            dtgHighscoresGame.Name = "dtgHighscoresGame";
            dtgHighscoresGame.RowHeadersWidth = 51;
            dtgHighscoresGame.RowTemplate.Height = 29;
            dtgHighscoresGame.Size = new Size(934, 389);
            dtgHighscoresGame.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "GameId";
            dataGridViewTextBoxColumn8.HeaderText = "GameId";
            dataGridViewTextBoxColumn8.MinimumWidth = 10;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // scoreDataGridViewTextBoxColumn1
            // 
            scoreDataGridViewTextBoxColumn1.DataPropertyName = "Score";
            scoreDataGridViewTextBoxColumn1.HeaderText = "Score";
            scoreDataGridViewTextBoxColumn1.MinimumWidth = 10;
            scoreDataGridViewTextBoxColumn1.Name = "scoreDataGridViewTextBoxColumn1";
            // 
            // createdDataGridViewTextBoxColumn1
            // 
            createdDataGridViewTextBoxColumn1.DataPropertyName = "Created";
            createdDataGridViewTextBoxColumn1.HeaderText = "Created";
            createdDataGridViewTextBoxColumn1.MinimumWidth = 10;
            createdDataGridViewTextBoxColumn1.Name = "createdDataGridViewTextBoxColumn1";
            // 
            // highscoreGameIndexBindingSource
            // 
            highscoreGameIndexBindingSource.DataSource = typeof(DTO.HighscoreGameIndex);
            // 
            // btnDetailsPlayer
            // 
            btnDetailsPlayer.Location = new Point(20, 458);
            btnDetailsPlayer.Margin = new Padding(5);
            btnDetailsPlayer.Name = "btnDetailsPlayer";
            btnDetailsPlayer.Size = new Size(153, 46);
            btnDetailsPlayer.TabIndex = 9;
            btnDetailsPlayer.Text = "Details";
            btnDetailsPlayer.UseVisualStyleBackColor = true;
            btnDetailsPlayer.Click += btnDetailsPlayer_Click;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(606, 458);
            btnAddPlayer.Margin = new Padding(5);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(153, 46);
            btnAddPlayer.TabIndex = 10;
            btnAddPlayer.Text = "Add";
            btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.Location = new Point(769, 458);
            btnDeletePlayer.Margin = new Padding(5);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Size = new Size(153, 46);
            btnDeletePlayer.TabIndex = 11;
            btnDeletePlayer.Text = "Delete";
            btnDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGame
            // 
            btnDeleteGame.Location = new Point(1802, 458);
            btnDeleteGame.Margin = new Padding(5);
            btnDeleteGame.Name = "btnDeleteGame";
            btnDeleteGame.Size = new Size(153, 46);
            btnDeleteGame.TabIndex = 14;
            btnDeleteGame.Text = "Delete";
            btnDeleteGame.UseVisualStyleBackColor = true;
            // 
            // btnAddGame
            // 
            btnAddGame.Location = new Point(1640, 458);
            btnAddGame.Margin = new Padding(5);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(153, 46);
            btnAddGame.TabIndex = 13;
            btnAddGame.Text = "Add";
            btnAddGame.UseVisualStyleBackColor = true;
            // 
            // btnDetailsGame
            // 
            btnDetailsGame.Location = new Point(1053, 458);
            btnDetailsGame.Margin = new Padding(5);
            btnDetailsGame.Name = "btnDetailsGame";
            btnDetailsGame.Size = new Size(153, 46);
            btnDetailsGame.TabIndex = 12;
            btnDetailsGame.Text = "Details";
            btnDetailsGame.UseVisualStyleBackColor = true;
            // 
            // btnDeleteHighscorePlayer
            // 
            btnDeleteHighscorePlayer.Location = new Point(801, 984);
            btnDeleteHighscorePlayer.Margin = new Padding(5);
            btnDeleteHighscorePlayer.Name = "btnDeleteHighscorePlayer";
            btnDeleteHighscorePlayer.Size = new Size(153, 46);
            btnDeleteHighscorePlayer.TabIndex = 17;
            btnDeleteHighscorePlayer.Text = "Delete";
            btnDeleteHighscorePlayer.UseVisualStyleBackColor = true;
            // 
            // btnAddHighscorePlayer
            // 
            btnAddHighscorePlayer.Location = new Point(639, 984);
            btnAddHighscorePlayer.Margin = new Padding(5);
            btnAddHighscorePlayer.Name = "btnAddHighscorePlayer";
            btnAddHighscorePlayer.Size = new Size(153, 46);
            btnAddHighscorePlayer.TabIndex = 16;
            btnAddHighscorePlayer.Text = "Add";
            btnAddHighscorePlayer.UseVisualStyleBackColor = true;
            // 
            // btnDetailsHighscorePlayer
            // 
            btnDetailsHighscorePlayer.Location = new Point(20, 984);
            btnDetailsHighscorePlayer.Margin = new Padding(5);
            btnDetailsHighscorePlayer.Name = "btnDetailsHighscorePlayer";
            btnDetailsHighscorePlayer.Size = new Size(153, 46);
            btnDetailsHighscorePlayer.TabIndex = 15;
            btnDetailsHighscorePlayer.Text = "Details";
            btnDetailsHighscorePlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteHighscoreGame
            // 
            btnDeleteHighscoreGame.Location = new Point(1835, 984);
            btnDeleteHighscoreGame.Margin = new Padding(5);
            btnDeleteHighscoreGame.Name = "btnDeleteHighscoreGame";
            btnDeleteHighscoreGame.Size = new Size(153, 46);
            btnDeleteHighscoreGame.TabIndex = 20;
            btnDeleteHighscoreGame.Text = "Delete";
            btnDeleteHighscoreGame.UseVisualStyleBackColor = true;
            // 
            // btnAddHighscoreGame
            // 
            btnAddHighscoreGame.Location = new Point(1672, 984);
            btnAddHighscoreGame.Margin = new Padding(5);
            btnAddHighscoreGame.Name = "btnAddHighscoreGame";
            btnAddHighscoreGame.Size = new Size(153, 46);
            btnAddHighscoreGame.TabIndex = 19;
            btnAddHighscoreGame.Text = "Add";
            btnAddHighscoreGame.UseVisualStyleBackColor = true;
            // 
            // btnDetailsHighscoreGame
            // 
            btnDetailsHighscoreGame.Location = new Point(1053, 984);
            btnDetailsHighscoreGame.Margin = new Padding(5);
            btnDetailsHighscoreGame.Name = "btnDetailsHighscoreGame";
            btnDetailsHighscoreGame.Size = new Size(153, 46);
            btnDetailsHighscoreGame.TabIndex = 18;
            btnDetailsHighscoreGame.Text = "Details";
            btnDetailsHighscoreGame.UseVisualStyleBackColor = true;
            // 
            // btnRollback
            // 
            btnRollback.Location = new Point(2072, 810);
            btnRollback.Margin = new Padding(5);
            btnRollback.Name = "btnRollback";
            btnRollback.Size = new Size(301, 106);
            btnRollback.TabIndex = 21;
            btnRollback.Text = "Rollback";
            btnRollback.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(2072, 925);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(307, 106);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // highscorePlayerIndexBindingSource
            // 
            highscorePlayerIndexBindingSource.DataSource = typeof(DTO.HighscorePlayerIndex);
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2398, 1050);
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
            Margin = new Padding(5);
            Name = "MainFrm";
            Text = "Highscores";
            Load += MainFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgHighscoresGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)highscoreGameIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)highscorePlayerIndexBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dtgPlayers;
        private DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridView dtgGames;
        private DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private BindingSource gameIndexBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn1;
        private BindingSource highscoreGameIndexBindingSource;
        private DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private BindingSource highscorePlayerIndexBindingSource;
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