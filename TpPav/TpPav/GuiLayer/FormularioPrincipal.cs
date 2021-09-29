﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TpPav
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-82E3KBS\\SQLEXPRESS;database=DB_TP; integrated security = true");

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "SELECT TOP 20 * FROM Usuarios ORDER BY id_usuario DESC";
                DataTable resultado = DataManager.GetInstance().ConsultaSql(consulta);
                dgvUsuarios.DataSource = resultado;
            }

            catch(SqlException ex)
            {
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            string consulta = "SELECT * FROM Usuarios where id_usuario > 0";
            if (txtNombre.Text != "")
                consulta += " AND usuario= '"+txtNombre.Text+"'";
            if (cboPerfil.Text != "")
                consulta += " AND id_perfil= "+cboPerfil.Text.ToString()+"";
            if (cboEstado.Text != "")
                consulta += " AND estado='" + cboEstado.Text.ToString() + "' ";
            if (txtEmail.Text != "")
                consulta += " AND email= '"+txtEmail.Text.ToString()+"'";

            DataTable tabla = DataManager.GetInstance().ConsultaSql(consulta);
            dgvUsuarios.DataSource = tabla;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNuevo frmUs = new frmNuevo();
            frmUs.Show();


        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btnModificar.Enabled == false)
            {
                btnModificar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar frm = new frmModificar();
            frm.txtId.Text = dgvUsuarios.SelectedCells[0].Value.ToString();
            frm.cboPerfil.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
            frm.txtNombre.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
            frm.txtPassword.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
            frm.txtEmail.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
            frm.cboEstado.Text = dgvUsuarios.SelectedCells[5].Value.ToString();
            this.Hide();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}