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
    public partial class frmNuevo : Form
    {
        public frmNuevo()
        {
            InitializeComponent();
        }
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || cboPerfil.Text == "" || cboEstado.Text =="")
            {
                MessageBox.Show("Debe ingresar los datos minimos");
            }
           
            else
            {
                try
                {
                    string consulta = "SELECT * FROM Usuarios WHERE usuario= '" + txtNombre.Text + "'";
                    DataTable resultado = DataManager.GetInstance().ConsultaSql(consulta);
                    if (resultado.Rows.Count == 0)
                    {
                        string comando = "insert into Usuarios values(" + cboPerfil.Text + ",'" + txtNombre.Text + "', '" + txtPassword.Text + "', '" + txtEmail.Text + "', '" + cboEstado.Text + "', " + 0 + ")";
                        int a = DataManager.GetInstance().EjecutarSql(comando);
                        MessageBox.Show("Nuevo usuario agregado con exito");
                        txtNombre.Text = "";
                        txtEmail.Text = "";
                        cboEstado.Text = "";
                        cboPerfil.Text = "";
                        txtPassword.Text = "";

                    }
                    else
                        MessageBox.Show("Error, ya existe un usuario con ese nombre: ");
                }

                catch(SqlException ex)
                {
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
        }
    }


}
