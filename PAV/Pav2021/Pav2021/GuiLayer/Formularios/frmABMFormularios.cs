
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
    public partial class frmABMFormularios : Form
    {

        private FormMode formMode = FormMode.nuevo;

        private readonly UsuarioService oUsuarioService;
        private readonly FormularioService oFormularioService;
        private Formulario oFormularioSelected;

        public frmABMFormularios()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
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
                        this.Text = "Nuevo Formulario";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Formulario";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();                        
                        txtNombre.Enabled = true;
                        txtId.Enabled = false;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Formulario";
                        txtNombre.Enabled = false;
                        txtId.Enabled = false;
                        break;
                    }
            }
        }

        public void InicializarFormulario(FormMode op, Formulario formularioSelected)
        {
            formMode = op;
            oFormularioSelected = formularioSelected;
        }

        private void MostrarDatos()
        {
            if (oFormularioSelected != null)
            {

                txtNombre.Text = oFormularioSelected.Nombre;
                txtId.Text = oFormularioSelected.Id_Formulario.ToString();
            }
        }

        private void btnAceptar_Click(System.Object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (ExisteFormulario() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oFormulario = new Formulario();
                                oFormulario.Nombre = txtNombre.Text;                                

                                if (oFormularioService.CrearFormulario(oFormulario))
                                {
                                    MessageBox.Show("Formulario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Formulario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.actualizar:
                    {
                        if (ValidarCampos())
                        {

                            oFormularioSelected.Id_Formulario = Convert.ToInt32(txtId.Text);
                            oFormularioSelected.Nombre = txtNombre.Text;

                            if (oFormularioService.ActualizarFormulario(oFormularioSelected))
                            {
                                MessageBox.Show("Formulario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Formulario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el formulario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {                         
                            if (oFormularioService.EliminarFormulario(oFormularioSelected))
                            {
                                MessageBox.Show("Formulario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el formulario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool ExisteFormulario()
        {
            return oFormularioService.ObtenerFormulario(txtNombre.Text) != null;
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
