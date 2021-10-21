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
    public partial class frmActualizar : Form
    {
        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;
        public frmActualizar()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfil, oPerfilService.ObtenerTodos(), "Nombre", "Id_Perfil");
            //LlenarCombo(cboEstado, oUsuarioService.ObtenerEstados(), "Estado", "");
            cboEstado.DisplayMember = "Text";
            cboEstado.ValueMember = "Value";
            cboEstado.SelectedIndex = cboEstado.Items.IndexOf("N");

            cboEstado.Items.Add(new { Text = "S", Value = 1 });
            cboEstado.Items.Add(new { Text = "N", Value = 0 });
            cboEstado.SelectedIndex = 0;
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
                if(oUsuarioService.ActualizarUsuario(consulta))
                {
                    MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmUsuarios usu = new frmUsuarios();
                    this.Close();
                    usu.Show();
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
            frmUsuarios usu = new frmUsuarios();
            usu.Show();
        }

       
    }
}
