using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Pav2021.BusinessLayer;
using Pav2021.Entities;

namespace Pav2021
{
    public partial class frmNuevo : Form
    {
        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;
        public frmNuevo()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }
        private void frmNuevo_Load(System.Object sender, System.EventArgs e)
        {
            
            LlenarCombo(cboPerfil, oPerfilService.ObtenerTodos(), "Nombre", "Id_Perfil");
            cboEstado.DisplayMember = "Text";
            cboEstado.ValueMember = "Value";
            cboEstado.SelectedIndex = cboEstado.Items.IndexOf('N');

            cboEstado.Items.Add(new { Text = 'S', Value = 1 });
            cboEstado.Items.Add(new { Text = 'N', Value = 0 });
            cboEstado.SelectedIndex = 0;
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
            
        }
    }


}
