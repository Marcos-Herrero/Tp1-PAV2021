
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
    public partial class frmABMPermisos : Form
    {

        private FormMode formMode = FormMode.nuevo;

        private readonly UsuarioService oUsuarioService;
        private readonly PermisoService oPermisoService;
        private Permiso oPermisoSelected;
        private PerfilService oPerfilService;
        private FormularioService oFormularioService;



        public frmABMPermisos()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPermisoService = new PermisoService();
            oPerfilService = new PerfilService();
            oFormularioService = new FormularioService();
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
                        LlenarCombo(cboIdPerfil, oPerfilService.ObtenerTodos(), "IdPerfil", "id_Perfil");
                        LlenarCombo(cboIdForm, oFormularioService.ObtenerTodos(), "IdFormulario", "id_Formulario");
                        this.Text = "Nuevo Permiso";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Permiso";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();                        
                        cboIdForm.Enabled = true;
                        cboIdPerfil.Enabled = true;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Permiso";
                        cboIdForm.Enabled = false;
                        cboIdPerfil.Enabled = false;
                        break;
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
        public void InicializarPermiso(FormMode op, Permiso PermisoSelected)
        {
            formMode = op;
            oPermisoSelected = PermisoSelected;
        }

        private void MostrarDatos()
        {
            if (oPermisoSelected != null)
            {

                cboIdForm.Text = oPermisoSelected.Formulario.Id_Formulario.ToString();
                cboIdPerfil.Text = oPermisoSelected.Perfil.Id_Perfil.ToString();
            }
        }

        private void btnAceptar_Click(System.Object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {/*
                        if (ExistePermiso() == false)
                        {*/
                            if (ValidarCampos())
                            {
                                var oPermiso = new Permiso();
                                Formulario form = oFormularioService.ObtenerFormPorID(Convert.ToInt32(cboIdForm.SelectedValue));
                                Perfil per = oPerfilService.ObtenerPerfilPorID(Convert.ToInt32(cboIdPerfil.SelectedValue));
                                oPermiso.Formulario = form;
                                oPermiso.Perfil= per;

                                if (oPermisoService.CrearPermiso(oPermiso))
                                {
                                    MessageBox.Show("Permiso insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        /*  }
                          else
                              MessageBox.Show("Permiso encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          */
                        break;
                    }

                case FormMode.actualizar:
                    {
                        if (ValidarCampos())
                        {
                            oPermisoSelected.Formulario.Id_Formulario = Convert.ToInt32(cboIdForm.SelectedValue);
                            oPermisoSelected.Perfil.Id_Perfil = Convert.ToInt32(cboIdPerfil.SelectedValue);


                            if (oPermisoService.ActualizarPermiso(oPermisoSelected))
                            {
                                MessageBox.Show("Permiso actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Permiso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el Permiso seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {                         
                            if (oPermisoService.EliminarPermiso(oPermisoSelected))
                            {
                                MessageBox.Show("Permiso Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Permiso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (cboIdForm.SelectedValue == string.Empty && cboIdPerfil.SelectedValue == string.Empty)
            {
                cboIdForm.BackColor = Color.Red;
                cboIdForm.Focus();
                cboIdPerfil.BackColor = Color.Red;
                cboIdPerfil.Focus();
                return false;
            }
            else
                cboIdForm.BackColor = Color.White;
                cboIdPerfil.BackColor = Color.White;

            return true;
        }

        private bool ExistePermiso()
        {
            return oPermisoService.ObtenerPermiso(Convert.ToInt32(cboIdForm.SelectedValue), Convert.ToInt32(cboIdPerfil.SelectedValue)) != null;
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
