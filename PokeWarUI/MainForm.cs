using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokeWarUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PokeWarControl control = UIManager.Instance.GetNextControl();
            control.Location = new Point(0, 0);
            control.Size = new Size(this.Width, this.Height);
            control.ControlComplete += MainForm_ControlComplete;
            this.Controls.Add(control);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.Controls[0].Size = new Size(this.Width, this.Height);
        }

        private void MainForm_ControlComplete()
        {
            this.Controls.RemoveAt(0);

            PokeWarControl control = UIManager.Instance.GetNextControl();
            control.Location = new Point(0, 0);
            control.Size = new Size(this.Width, this.Height);
            control.ControlComplete += MainForm_ControlComplete;
            this.Controls.Add(control);
        }

    }
}
