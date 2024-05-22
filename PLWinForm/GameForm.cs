using DTO;
using HighScoreGUI;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLWinForm
{
    public partial class GameForm : Form
    {
        public WindowType windowType { get; set; }
        public GameDetail? Game { get; set; }
        public GameDetail? GameAdd { get; set; }

        public GameForm(WindowType window, GameDetail? g = null)
        {

            Game = g;

            windowType = window;
            InitializeComponent();

            label1.Text = "Title";
            label2.Text = "Publisher";
            label3.Text = "ReleaseDate";
            label4.Text = "Entry";
            label5.Text = "Exit";

            switch (windowType)
            {
                case WindowType.Add:
                    this.Text = "Add Game";
                    btnSaveForm.Text = "Save";
                    btnRevertForm.Text = "Abort";
                    label4.Text = "";
                    Field4.Visible = false;
                    Entry.Visible = false;
                    Exit.Enabled = false;
                    break;
                case WindowType.Edit:
                    this.Text = "Edit Game";
                    btnSaveForm.Text = "Update";
                    btnRevertForm.Text = "Abort";

                    ReleaseDate.Enabled = false;
                    Exit.Enabled = false;
                    LoadData(Game);
                    break;
                case WindowType.View:
                    this.Text = "View Game";
                    btnSaveForm.Visible = false;
                    btnRevertForm.Text = "Close";

                    Field1.ReadOnly = true;
                    Publisher.ReadOnly = true;
                    Field3.ReadOnly = true;
                    Field4.ReadOnly = true;
                    Field5.ReadOnly = true;
                    inpNotes.ReadOnly = true;

                    ReleaseDate.Enabled = false;
                    Entry.Enabled = false;
                    Exit.Enabled = false;
                    LoadData(Game);
                    break;
                default:
                    break;
            }

        }

        private void LoadData(GameDetail g)
        {
            Field1.DataBindings.Add("Text", g, "Title");
            Publisher.DataBindings.Add("Text", g, "Publisher");
            Field5.DataBindings.Add("Text", g, "Notes");
           
            ReleaseDate.Text = g.ReleaseDate.ToString();
            Entry.DataBindings.Add("Text", g, "Entry");
            Exit.DataBindings.Add("Text", g, "Exit");

        }
        public MainFrm.AddGameDelegate AddGame = delegate { };
        public MainFrm.UpdateGameDelegate UpdateGame = delegate { };
        private void btnSaveForm_Click(object sender, EventArgs e)
        {
            if (windowType == WindowType.Add)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save?", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddGame(new GameDetail
                    {
                        Title = Field1.Text,
                        Publisher = Publisher.Text,
                        ReleaseDate = DateOnly.Parse(ReleaseDate.Text),
                        Notes = Field5.Text,
                        Entry = DateTime.Now,
                    });

                    this.Close();
                }
            }
            else if (windowType == WindowType.Edit)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UpdateGame(Game);
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
