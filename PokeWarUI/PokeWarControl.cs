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
    public partial class PokeWarControl : UserControl
    {
        public delegate void ControlCompleteHandler();
        public event ControlCompleteHandler ControlComplete;

        public PokeWarControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the data in the control.
        /// </summary>
        public virtual void Clean()
        {

        }

        protected void OnControlComplete()
        {
            if (ControlComplete != null)
                ControlComplete();
        }
    }
}
