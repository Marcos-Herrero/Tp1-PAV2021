using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TpPav.GuiLayer
{
    public partial class frmVentana : Form
    {
        public frmVentana(bool admin)
        {
            if(admin)
            {
                InitializeComponent();
                usuariosMenu.Enabled = true;

            }
            else
                InitializeComponent();
        }
        public frmVentana()
        {
            InitializeComponent();
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
