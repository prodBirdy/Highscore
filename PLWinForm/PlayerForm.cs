using BL;
using DTO;
using HighScoreGUI;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PLWinForm
{
    public partial class PlayerForm : Form
    {

        public WindowType windowType { get; set; }
        public PlayerDetail Player { get; set;  }
        public PlayerDetail PlayerAdd { get; set; }

        public PlayerForm(WindowType window, PlayerDetail p = null)
        {

            Player = p;

            windowType = window;
            InitializeComponent();

            label1.Text = "FName";
            label2.Text = "LName";
            label3.Text = "BirthDay";
            label4.Text = "Entry";
            label5.Text = "Exit";
           
            switch (windowType)
            {
                case WindowType.Add:
                    this.Text = "Add Player";
                    btnSaveForm.Text = "Save";
                    btnRevertForm.Text = "Abort";
                    label4.Text = "Password";
                    Entry.Visible = false;
                    Exit.Enabled = false;
                    break;
                case WindowType.Edit:
                    this.Text = "Edit Player";
                    btnSaveForm.Text = "Update";
                    btnRevertForm.Text = "Abort";

                    BirthDate.Enabled = false;
                    Exit.Enabled = false;
                    LoadData(Player);
                    break;
                case WindowType.View:
                    this.Text = "View Player";
                    btnSaveForm.Visible = false;
                    btnRevertForm.Text = "Close";

                    Field1.ReadOnly = true;
                    Field2.ReadOnly = true;
                    Field3.ReadOnly = true;
                    Field4.ReadOnly = true;
                    Field5.ReadOnly = true;
                    inpNotes.ReadOnly = true;

                    BirthDate.Enabled = false;
                    Entry.Enabled = false;
                    Exit.Enabled = false;
                    LoadData(Player);
                    break;
                default:
                    break;
            }

        }

        private void LoadData(PlayerDetail p)
        {
            Field1.DataBindings.Add("Text", p, "FName");
            Field2.DataBindings.Add("Text", p, "LName");
            Field5.DataBindings.Add("Text", p, "Notes");

            BirthDate.DataBindings.Add("Value", p, "BirthDay", true, DataSourceUpdateMode.OnPropertyChanged, DateTime.Now, "d");
            Entry.DataBindings.Add("Value", p, "Entry");
            Exit.DataBindings.Add("Value", p, "Exit", true, DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);

        }
        public MainFrm.AddPlayerDelegate AddPlayer = delegate { };
        public MainFrm.UpdatePlayerDelegate UpdatePlayer = delegate { };


        private void btnSaveForm_Click(object sender, EventArgs e)
        {
            //TODO: Save data
            //add a dialog with yes and no
            if(windowType == WindowType.Add) 
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save?", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddPlayer(new PlayerAdd
                    {
                        FName = Field1.Text,
                        LName = Field2.Text,
                        BirthDay = DateOnly.FromDateTime(BirthDate.Value.Date),
                        Notes = Field5.Text,
                        Entry = DateTime.Now,
                        Pw = Field4.Text,
                    });

                    this.Close();
                }
            }
            else if(windowType == WindowType.Edit)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UpdatePlayer(Player);
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
