using DTO;
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

namespace PLWinForm
{
    public partial class PlayerForm : Form
    {

        public WindowType windowType { get; set; }

        public PlayerForm(WindowType window, PlayerDetail p = null)
        {
            windowType = window;
            InitializeComponent();

            label1.Text = "FName";
            label2.Text = "LName";
            label3.Text = "BirthDay";
            label4.Text = "Entry";
            label5.Text = "Exit";

            Field1.DataBindings.Add("Text", p, "FName");
            Field2.DataBindings.Add("Text", p, "LName");
            Field5.DataBindings.Add("Text", p, "Notes");

            dateTimePicker3.DataBindings.Add("Value", p, "BirthDay", true, DataSourceUpdateMode.OnPropertyChanged, DateTime.Now, "d");
            dateTimePicker4.DataBindings.Add("Value", p, "Entry");
            dateTimePicker5.DataBindings.Add("Value", p, "Exit", true, DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);

            switch (windowType)
            {
                case WindowType.Add:
                    this.Text = "Add Player";
                    btnSaveForm.Text = "Save";
                    btnRevertForm.Text = "Abort";
                    break;
                case WindowType.Edit:
                    this.Text = "Edit Player";
                    btnSaveForm.Text = "Update";
                    btnRevertForm.Text = "Abort";

                    dateTimePicker3.Enabled = false;
                    dateTimePicker5.Enabled = false;
                    break;
                case WindowType.View:
                    this.Text = "Delete Player";
                    btnSaveForm.Visible = false;
                    btnRevertForm.Text = "Close";

                    Field1.ReadOnly = true;
                    Field2.ReadOnly = true;
                    Field3.ReadOnly = true;
                    Field4.ReadOnly = true;
                    Field5.ReadOnly = true;
                    inpNotes.ReadOnly = true;

                    dateTimePicker3.Enabled = false;
                    dateTimePicker4.Enabled = false;
                    dateTimePicker5.Enabled = false;
                    break;
                default:
                    break;
            }

        }



        private void btnSaveForm_Click(object sender, EventArgs e)
        {


        }

        private void btnRevertForm_Click(object sender, EventArgs e)
        {

        }
    }
}
