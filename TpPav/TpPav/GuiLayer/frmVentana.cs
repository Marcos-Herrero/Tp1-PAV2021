using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TpPav.GUILayer.Formularioes;
using TpPav.GUILayer.Perfiles;
using TpPav.GUILayer.Permisoes;

namespace TpPav.GuiLayer
{
    public partial class frmVentana : Form
    {
        public frmVentana(bool admin)
        {
            if (admin)
            {
                InitializeComponent();
                administrarUsuarios.Enabled = true;


            }
            else
                InitializeComponent();
        }
        public frmVentana()
        {
            InitializeComponent();
        }

        private void frmVentana_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        

        
        private void frmVentana_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

        private void formulariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPerfiles frmPer = new frmPerfiles();
            frmPer.ShowDialog();
        }

        

        private void administrarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermisos frmForm = new frmPermisos();
            frmForm.ShowDialog();
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormularios frmForm = new frmFormularios();
            frmForm.ShowDialog();
        }

        private void administrarUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuarios frmDetalle = new frmUsuarios();
            frmDetalle.ShowDialog();
        }
    }

}
