using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TpPav.Entities;
using TpPav.BusinessLayer;
using TpPav.GUILayer.Usuarios;

namespace TpPav.GUILayer.Permisoes
{
    public partial class frmPermisos : Form
    {

        private FormularioService oFormularioService;
        private PerfilService oPerfilService;
        private PermisoService oPermisoService;


        public frmPermisos()
        {
            InitializeComponent();
            InitializeDataGridView();
            oPermisoService = new PermisoService();
            oPerfilService= new PerfilService();
            oFormularioService = new FormularioService();

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfil, oPerfilService.ObtenerTodos(), "IdPerfil", "id_Perfil");
            LlenarCombo(cboIdFormulario, oFormularioService.ObtenerTodos(), "IdFormulario", "id_Formulario");
            this.CenterToParent();
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMPermisos Permiso = new frmABMPermisos();
            Permiso.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkTodos.Checked)
                {
                    cboIdFormulario.Enabled = false;
                    cboPerfil.Enabled = false;
                }
                else
                {
                    cboIdFormulario.Enabled = true;
                    cboPerfil.Enabled = true;
                }
            }
        }

        private void btnSalir_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboPerfil.Text = "";
            cboIdFormulario.Text = "";
        }
        private void btnConsultar_Click(System.Object sender, System.EventArgs e)
        {
            var filters = new Dictionary<string, object>();

            if (!chkTodos.Checked)
            {
                // Validar si el combo 'Permisoes' esta seleccionado.
                if (cboPerfil.Text != string.Empty)
                {
                    // Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add("nombre", cboPerfil.SelectedValue);
                }

                // Validar si el textBox 'Nombre' esta vacio.
                if (cboIdFormulario.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("idPermiso", cboIdFormulario.SelectedValue);
                }

                if (filters.Count > 0)
                    dgvPermisos.DataSource = oPermisoService.ObtenerPermisoesFiltro(filters);
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                dgvPermisos.DataSource = oPermisoService.ObtenerTodos();
        }

        private void btnEditar_Click(System.Object sender, System.EventArgs e)
        {
            frmABMPermisos Permiso = new frmABMPermisos();

            // Asi obtenemos el item seleccionado de la grilla.
            var frm= (Permiso) dgvPermisos.CurrentRow.DataBoundItem;
            Permiso.InicializarPermiso(frmABMPermisos.FormMode.actualizar, frm);
            Permiso.ShowDialog();

            //Forzamos el evento Click para actualizar el DataGridView.
            btnConsultar_Click(sender, e);
        }

        private void dgvUsers_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnQuitar.Enabled = true;
        }

        private void btnQuitar_Click(System.Object sender, System.EventArgs e)
        {
            frmABMPermisos Permiso = new frmABMPermisos();

            // Asi obtenemos el item seleccionado de la grilla.
            var frm = (Permiso)dgvPermisos.CurrentRow.DataBoundItem;

            Permiso.InicializarPermiso(frmABMPermisos.FormMode.eliminar, frm);
            Permiso.ShowDialog();

            //Forzamos el evento Click para actualizar el DataGridView.
            btnConsultar_Click(sender, e);
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvPermisos.ColumnCount = 3;
            dgvPermisos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvPermisos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvPermisos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvPermisos.Columns[0].Name = "ID Permiso";
            dgvPermisos.Columns[0].DataPropertyName = "id_Permiso";
            // Definimos el ancho de la columna.            

            dgvPermisos.Columns[1].Name = "Permiso";
            dgvPermisos.Columns[1].DataPropertyName = "nombre";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvPermisos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvPermisos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

       
    }
}
