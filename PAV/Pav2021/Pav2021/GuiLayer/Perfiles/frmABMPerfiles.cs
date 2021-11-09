
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pav2021.BusinessLayer;
using Pav2021.Entities;

namespace Pav2021.GUILayer.Usuarios
{
    public partial class frmABMPerfiles: Form
    {

        private FormMode formMode = FormMode.nuevo;

        private readonly UsuarioService oUsuarioService;
        private readonly PerfilService oPerfilService;
        private Perfil oPerfilSelected;

        public frmABMPerfiles()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }


        private void frmABMUsuario_Load(System.Object sender, System.EventArgs e)
        {
            
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nuevo Perfil";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Perfil";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();                        
                        txtNombre.Enabled = true;
                        txtId.Enabled = false;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Perfil";
                        txtNombre.Enabled = false;
                        txtId.Enabled = false;
                        break;
                    }
            }
        }

        public void InicializarFormulario(FormMode op, Perfil perfilSelected)
        {
            formMode = op;
            oPerfilSelected = perfilSelected;
        }

        private void MostrarDatos()
        {
            if (oPerfilSelected != null)
            {

                txtNombre.Text = oPerfilSelected.Nombre;
                txtId.Text = oPerfilSelected.Id_Perfil.ToString();
            }
        }

        private void btnAceptar_Click(System.Object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (ExistePerfil() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oPerfil = new Perfil();
                                oPerfil.Nombre = txtNombre.Text;                                

                                if (oPerfilService.CrearPerfil(oPerfil))
                                {
                                    MessageBox.Show("Perfil insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Perfil encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.actualizar:
                    {
                        if (ValidarCampos())
                        {

                            oPerfilSelected.Id_Perfil = Convert.ToInt32(txtId.Text);
                            oPerfilSelected.Nombre = txtNombre.Text;

                            if (oPerfilService.ActualizarPerfil(oPerfilSelected))
                            {
                                MessageBox.Show("Perfil actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el perfil seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {                         
                            if (oPerfilService.EliminarPerfil(oPerfilSelected))
                            {
                                MessageBox.Show("Perfil Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Perfil!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;

            return true;
        }

        private bool ExistePerfil()
        {
            return oPerfilService.ObtenerPerfil(txtNombre.Text) != null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

      
    }
}
