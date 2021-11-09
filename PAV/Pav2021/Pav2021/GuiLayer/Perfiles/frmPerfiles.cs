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
using Pav2021.Entities;
using Pav2021.BusinessLayer;
using Pav2021.GUILayer.Usuarios;

namespace Pav2021.GUILayer.Perfiles
{
    public partial class frmPerfiles : Form
    {

        
        private PerfilService oPerfilService;

        public frmPerfiles()
        {
            InitializeComponent();
            InitializeDataGridView();
            oPerfilService = new PerfilService();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfiles, oPerfilService.ObtenerTodos(), "Nombre", "nombre");
            LlenarCombo(cboIdPerfil, oPerfilService.ObtenerTodos(), "IdPerfil", "id_perfil");
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
            frmABMPerfiles formulario = new frmABMPerfiles();
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkTodos.Checked)
                {
                    cboIdPerfil.Enabled = false;
                    cboPerfiles.Enabled = false;
                }
                else
                {
                    cboIdPerfil.Enabled = true;
                    cboPerfiles.Enabled = true;
                }
            }
        }

        private void btnSalir_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(System.Object sender, System.EventArgs e)
        {
            var filters = new Dictionary<string, object>();

            if (!chkTodos.Checked)
            {
                // Validar si el combo 'Perfiles' esta seleccionado.
                if (cboPerfiles.Text != string.Empty)
                {
                    // Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add("nombre", cboPerfiles.SelectedValue);
                }

                // Validar si el textBox 'Nombre' esta vacio.
                if (cboIdPerfil.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("idPerfil", cboIdPerfil.SelectedValue);
                }

                if (filters.Count > 0)
                    dgvPerfiles.DataSource = oPerfilService.ObtenerPerfilesFiltro(filters);
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                dgvPerfiles.DataSource = oPerfilService.ObtenerTodos();
        }

        private void btnEditar_Click(System.Object sender, System.EventArgs e)
        {
            frmABMPerfiles formulario = new frmABMPerfiles();

            // Asi obtenemos el item seleccionado de la grilla.
            var perfil = (Perfil)dgvPerfiles.CurrentRow.DataBoundItem;
            formulario.InicializarFormulario(frmABMPerfiles.FormMode.actualizar, perfil);
            formulario.ShowDialog();

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
            frmABMPerfiles formulario = new frmABMPerfiles();

            // Asi obtenemos el item seleccionado de la grilla.
            var perfil = (Perfil)dgvPerfiles.CurrentRow.DataBoundItem;

            formulario.InicializarFormulario(frmABMPerfiles.FormMode.eliminar, perfil);
            formulario.ShowDialog();

            //Forzamos el evento Click para actualizar el DataGridView.
            btnConsultar_Click(sender, e);
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvPerfiles.ColumnCount = 3;
            dgvPerfiles.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvPerfiles.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvPerfiles.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvPerfiles.Columns[0].Name = "ID Perfil";
            dgvPerfiles.Columns[0].DataPropertyName = "id_perfil";
            // Definimos el ancho de la columna.            

            dgvPerfiles.Columns[1].Name = "Perfil";
            dgvPerfiles.Columns[1].DataPropertyName = "nombre";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvPerfiles.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvPerfiles.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

       
    }
}
