using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokeWar
{
    public partial class PokeWarControl : UserControl
    {
        public delegate void ControlCompleteHandler();
        public event ControlCompleteHandler ContolComplete;

        public PokeWarControl()
        {
            InitializeComponent();
        }
    }
}
