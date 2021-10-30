using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TpPav.GuiLayer;
using TpPav.BusinessLayer;
using TpPav.Entities;



namespace TpPav
{
    public partial class frmUsuarios : Form
    {
        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;
        public frmUsuarios()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();

        }



        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                                            
                IList<Usuario> resultado = oUsuarioService.getUsuariosList();
                dgvUsuarios.DataSource = resultado;
            }

            catch(SqlException ex)
            {
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevo formulario = new frmNuevo();
            formulario.ShowDialog();
        
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var nombre = txtNombre.Text;
                parametros.Add("nombre", nombre);
            }

            if (!string.IsNullOrEmpty(cboPerfil.Text))
            {
                var perfil = cboPerfil.Text;
                parametros.Add("nombre", perfil);
            }

            if (!string.IsNullOrEmpty(cboEstado.Text))
            {
                var estado = cboEstado.Text.ToString();
                parametros.Add("estado", estado);
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                var email = txtEmail.Text.ToString();
                parametros.Add("email", email);
            }
        
            IList<Usuario> listadoBugs = oUsuarioService.ConsultarUsuarioConFiltros(parametros);

            dgvUsuarios.DataSource = listadoBugs;

            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnModificar_Click(System.Object sender, System.EventArgs e)
        {
            frmModificar frm = new frmModificar();
            frm.txtId.Text = dgvUsuarios.SelectedCells[0].Value.ToString();
            frm.cboPerfil.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
            frm.txtNombre.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
            frm.txtPassword.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
            frm.txtEmail.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
            frm.cboEstado.Text = dgvUsuarios.SelectedCells[5].Value.ToString();
            this.Hide();
            frm.Show();
        }
        /*
        private void btnEliminar_Click(System.Object sender, System.EventArgs e)
        {
            frmEliminar frm = new frmEliminar();            
            frm.cboPerfil.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
            frm.txtNombre.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
            frm.txtPassword.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
            frm.txtEmail.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
            frm.cboEstado.Text = dgvUsuarios.SelectedCells[5].Value.ToString();
            this.Hide();
            frm.Show();
        }*/



        /*
          private void btnQuitar_Click(System.Object sender, System.EventArgs e)
          {
              frmABMUsuario formulario = new frmABMUsuario();

              // Asi obtenemos el item seleccionado de la grilla.
              var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

              formulario.InicializarFormulario(frmABMUsuario.FormMode.eliminar, usuario);
              formulario.ShowDialog();

              //Forzamos el evento Click para actualizar el DataGridView.
              btnConsultar_Click(sender, e);
          }

          */


        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btnModificar.Enabled == false)
            {
                btnModificar.Enabled = true;
            }
            if (btnEliminar.Enabled == false)
                btnEliminar.Enabled = true;
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtEmail.Text = "";
            cboEstado.Text = "";
            cboPerfil.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario consulta = new Usuario();
                consulta.Id_Usuario = (int)dgvUsuarios.SelectedCells[0].Value;
                consulta.UsuarioNombre = dgvUsuarios.SelectedCells[2].Value.ToString();
                consulta.Password = dgvUsuarios.SelectedCells[3].Value.ToString();
                consulta.Email = dgvUsuarios.SelectedCells[4].Value.ToString();
                consulta.Estado = dgvUsuarios.SelectedCells[5].Value.ToString();


                if (oUsuarioService.EliminarUsuario(consulta))
                {
                    MessageBox.Show("Usuario Borrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch { }
            
        }
    }
}