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
    public partial class frmActualizar : Form
    {
        private readonly BindingList<Permiso> listaPermisos;
        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;
        private FormularioService oFormularioService;

        public frmActualizar()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
            oFormularioService = new FormularioService();
            listaPermisos = new BindingList<Permiso>();

        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            LlenarCombo(_cboFormularios, oFormularioService.ObtenerTodos(), "Nombre", "id_Formulario");
            dgvDetalle.DataSource = listaPermisos;
            this.txtPerfil.TextChanged += new System.EventHandler(this.txtPerfil_TextChanged);

        }
        private void _btnAgregar_Click(object sender, EventArgs e)
        {

            var form = (Formulario)_cboFormularios.SelectedItem;
            Perfil per = new Perfil();
            per.Nombre = txtPerfil.Text;
            per.borrado = false;

            listaPermisos.Add(new Permiso()            
            {
                Formulario = form,
                Perfil = per
                            
        }) ;
            InicializarDetalle();

        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                var perfil = new Perfil
                {
                    Nombre = txtPerfil.Text,
                    DetallePermisos = listaPermisos                  
                };

                if (oPerfilService.ValidarDatos(perfil))
                {
                    oPerfilService.CrearPerfil(perfil);

                    MessageBox.Show(string.Concat("El detalle nro: ", perfil.Id_Perfil, " se generó correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    InicializarFormulario();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el perfil! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidarDatos()
        {
            return true;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
            txtPerfil.Enabled = true;
        }

        private void InicializarFormulario()
        {
                     
            InicializarDetalle();

            

        }
        private void InicializarDetalle()
        {
            _cboFormularios.SelectedIndex = -1;
            txtPerfil.Text = "";
            
        }
        private void _cboFormularios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cboFormularios.SelectedItem != null)
            {
                var form = (Formulario)_cboFormularios.SelectedItem;                
                _btnAgregar.Enabled = true;
            }
            else
            {
                _btnAgregar.Enabled = false;                
            }
        }
        private void _btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                var permisoSeleccionado = (Permiso)dgvDetalle.CurrentRow.DataBoundItem;
                listaPermisos.Remove(permisoSeleccionado);
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
        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarDetalle();
        }

        private void txtPerfil_TextChanged(object sender, EventArgs e)
        {
            dpbDetalle.Enabled = true;
        }

        private void _cboFormularios_Click(object sender, EventArgs e)
        {
            txtPerfil.Enabled = false;
        }
    }
}
