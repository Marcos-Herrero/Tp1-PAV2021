using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TpPav.BusinessLayer;
using TpPav.Entities;

namespace TpPav
{
    public partial class frmEliminar : Form
    {
        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;
        public frmEliminar()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
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
                    Usuario consulta = new Usuario();
                    consulta=(Usuario) oUsuarioService.ObtenerUsuario(txtNombre.Text);
                                        
                    if (consulta == null)
                    {
                        var oUsuario = new Usuario();
                        oUsuario.UsuarioNombre = txtNombre.Text;
                        oUsuario.Password = txtPassword.Text;
                        oUsuario.Email = txtEmail.Text;
                        oUsuario.Perfil = new Perfil();
                        oUsuario.Perfil.Id_Perfil = (int)cboPerfil.SelectedValue;
                        oUsuario.Estado = cboEstado.Text;
                        if (oUsuarioService.CrearUsuario(oUsuario))
                        {
                            MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                       

                    }
                    else
                        MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch(SqlException ex)
                {
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
        }
    }


}
