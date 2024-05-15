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

            

            switch (windowType)
            {
                case WindowType.Add:
                    this.Text = "Add Player";

                    break;
                case WindowType.Edit:
                    this.Text = "Edit Player";
                    if (p != null)
                    {
                        LoadData(p);

                    }
                    break;
                case WindowType.View:
                    this.Text = "Delete Player";
                    btnSaveForm.Visible = false;
                    btnRevertForm.Text = "Close";

                    if(p != null)
                    {
                        LoadData(p);

                    }

                    break;
                default:
                    break;
            }

        }

        private void LoadData(PlayerDetail p)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            Field1.Text = p.FName;
            Field2.Text = p.LName;

            Field3.Visible = false;
            Field4.Visible = false;

            dateTimePicker3.Value = p.BirthDay.ToDateTime(new TimeOnly());
            dateTimePicker4.Value = p.Entry;
            try
            {
                dateTimePicker5.Value = (DateTime)p.Exit;
            }
            catch (Exception)
            {
                dateTimePicker5.Visible = false;
            }
            Field5.Text = p.Notes;
        }

        private void btnSaveForm_Click(object sender, EventArgs e)
        {
           

        }

        private void btnRevertForm_Click(object sender, EventArgs e)
        {

        }
    }
}
