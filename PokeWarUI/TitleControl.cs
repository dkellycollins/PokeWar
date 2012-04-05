using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokeWarUI
{
    public partial class TitleControl : PokeWarControl
    {
        public TitleControl()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            OnControlComplete();
        }
}
