using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokeWar
{
    public partial class MainForm : Form
    {
        private StateManager sm;

        public MainForm()
        {
            sm = new StateManager();
            InitializeComponent();
        }

        private void LoadNextState(object sender, EventArgs e)
        {
            this.ActiveControl = sm.GetNextState();
        }
    }
}
