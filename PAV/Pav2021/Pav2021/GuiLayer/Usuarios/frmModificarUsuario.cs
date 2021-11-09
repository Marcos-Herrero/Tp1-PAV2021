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
    public partial class frmModificar : Form
    {
        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;
        private Usuario usr;
        public frmModificar()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
            usr = new Usuario();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfil, oPerfilService.ObtenerTodos(), "Nombre", "Id_Perfil");
            
            cboEstado.DisplayMember = "Text";
            cboEstado.ValueMember = "Value";
            cboEstado.SelectedIndex = cboEstado.Items.IndexOf("N");
            cboEstado.Items.Add(new { Text = 'S', Value = 0 });
            cboEstado.Items.Add(new { Text = 'N', Value = 1 });
            cboEstado.SelectedIndex = 0;
            usr = oUsuarioService.GetUsuarioById(Convert.ToInt32(txtId.Text));
            cboPerfil.SelectedIndex = cboPerfil.FindString(usr.Perfil.Nombre);
                
        }
        
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario consulta = new Usuario();
                consulta.UsuarioNombre = txtNombre.Text;
                consulta.Password = txtPassword.Text;
                consulta.Email = txtEmail.Text;
                consulta.Perfil = new Perfil();
                consulta.Perfil.Id_Perfil = (int)cboPerfil.SelectedValue;
                consulta.Estado = cboEstado.Text;
                consulta.Id_Usuario = Convert.ToInt32(txtId.Text);

                if (usr.Perfil.Id_Perfil == (int)cboPerfil.SelectedValue)
                {
                    if (oUsuarioService.ActualizarUsuario(consulta))
                    {
                        MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmUsuarios usu = new frmUsuarios();
                        this.Close();
                        
                    }
                }
                else
                {
                    if (oUsuarioService.ActualizarUsuarioConHistorial(consulta))
                    {
                        MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmUsuarios usu = new frmUsuarios();
                        this.Close();
                        

                    }
                }
                
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
