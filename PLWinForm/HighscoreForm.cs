using DTO;
using HighScoreGUI;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.DataFormats;

namespace PLWinForm
{
    public partial class HighscoreForm : Form
    {
        public WindowType windowType { get; set; }
        private PlayerIndex player;
        private GameIndex game;
        private List<SelectItem> items;
        public HighscoreIndex? highscore { get; set; }
        public HighscoreForm(WindowType window, HighscoreIndex h = null , PlayerIndex p = null , GameIndex g = null , List <SelectItem> Selects = null)
        {
            InitializeComponent();

            highscore = h;
            game = g;
            player = p;

            items = Selects;
            windowType = window;

            if (g != null)
            {
                label1.Text = "Game";
            }
            else if (p != null)
            {
                label1.Text = "Player";
            }
            else
            {
                label1.Text = "No Data";
            }
            label2.Text = "Score";


            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "DisplayMember";
            comboBox1.ValueMember = "ValueMember";
            //set current combobox value to highscore player or game id depending on which is not null
            if (highscore.GameId != 0)
            {
                comboBox1.SelectedValue = highscore.GameId;
            }
            else if (highscore.PlayerId != 0)
            {
                comboBox1.SelectedValue = highscore.PlayerId;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
            scoreInput.Maximum = 100000;
            switch (windowType)
            {
                case WindowType.Add:
                    this.Text = "Add Game";
                    btnSaveForm.Text = "Save";
                    btnRevertForm.Text = "Abort";

                    break;
                case WindowType.Edit:
                    this.Text = "Edit Game";
                    btnSaveForm.Text = "Update";
                    btnRevertForm.Text = "Abort";

                    LoadData(highscore);
                    break;
                case WindowType.View:
                    this.Text = "View Game";
                    btnSaveForm.Visible = false;
                    btnRevertForm.Text = "Close";

                    comboBox1.Enabled = false;
                    scoreInput.Enabled = false;


                    LoadData(highscore);
                    break;
                default:
                    break;
            }
        }

        private void LoadData(HighscoreIndex h)
        {
      
            scoreInput.DataBindings.Add("Value", h, "Score");
            
        }
        public MainFrm.AddHighScoreDelegate AddHighScore = delegate { };
        public MainFrm.UpdateHighScoreDelegate UpdateHighScore = delegate { };

        private void addHighScoreButton_Click(object sender, EventArgs e)
        {


            if (windowType == WindowType.Add)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save?", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (game is null)
                    {
                        highscore.GameId = (int)comboBox1.SelectedValue;
                        highscore.Score = Convert.ToInt32(scoreInput.Value);
                        highscore.Created = DateTime.Now;
                        AddHighScore(highscore);
                    }
                    else
                    {
                        highscore.PlayerId = (int)comboBox1.SelectedValue;
                        highscore.Score = Convert.ToInt32(scoreInput.Value);
                        highscore.Created = DateTime.Now;
                        AddHighScore(highscore);
                    }

                    this.Close();
                }
            }
            else if (windowType == WindowType.Edit)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UpdateHighScore(highscore);
                    this.Close();
                }
            }

        }
        private void btnRevertForm_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
