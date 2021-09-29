using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TpPav
{
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-82E3KBS\\SQLEXPRESS;database=DB_TP; integrated security = true");
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string comando = "update Usuarios set id_perfil=" + cboPerfil.Text + ", usuario='" + txtNombre.Text + "', email= '" + txtEmail.Text + "', estado= '" + cboEstado.Text + "'where id_usuario=" + txtId.Text + "";
                int a = DataManager.GetInstance().EjecutarSql(comando);
                MessageBox.Show("Modificado con exito");
                frmUsuarios usu = new frmUsuarios();
                this.Close();
                usu.Show();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsuarios usu = new frmUsuarios();
            usu.Show();
        }
    }
}
