using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLWinForm
{
    public partial class PlayerForm : Form
    {

        public WindowType windowType { get; set; }
        
        public PlayerForm(WindowType window)
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
                    break;
                case WindowType.View:
                    this.Text = "Delete Player";
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
