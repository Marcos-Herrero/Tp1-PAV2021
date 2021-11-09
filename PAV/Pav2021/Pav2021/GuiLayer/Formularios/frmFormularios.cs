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

namespace Pav2021.GUILayer.Formularioes
{
    public partial class frmFormularios : Form
    {

        private FormularioService oFormularioService;

        public frmFormularios()
        {
            InitializeComponent();
            InitializeDataGridView();
            oFormularioService = new FormularioService();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboFormularios, oFormularioService.ObtenerTodos(), "Nombre", "nombre");
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
            frmABMFormularios formulario = new frmABMFormularios();
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkTodos.Checked)
                {
                    cboIdFormulario.Enabled = false;
                    cboFormularios.Enabled = false;
                }
                else
                {
                    cboIdFormulario.Enabled = true;
                    cboFormularios.Enabled = true;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboFormularios.Text = "";
            cboFormularios.Text = "";
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
                // Validar si el combo 'Formularioes' esta seleccionado.
                if (cboFormularios.Text != string.Empty)
                {
                    // Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add("nombre", cboFormularios.SelectedValue);
                }

                // Validar si el textBox 'Nombre' esta vacio.
                if (cboIdFormulario.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("idFormulario", cboIdFormulario.SelectedValue);
                }

                if (filters.Count > 0)
                    dgvFormularios.DataSource = oFormularioService.ObtenerFormularioesFiltro(filters);
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                dgvFormularios.DataSource = oFormularioService.ObtenerTodos();
        }

        private void btnEditar_Click(System.Object sender, System.EventArgs e)
        {
            frmABMFormularios formulario = new frmABMFormularios();

            // Asi obtenemos el item seleccionado de la grilla.
            var frm= (Formulario) dgvFormularios.CurrentRow.DataBoundItem;
            formulario.InicializarFormulario(frmABMFormularios.FormMode.actualizar, frm);
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
            frmABMFormularios formulario = new frmABMFormularios();

            // Asi obtenemos el item seleccionado de la grilla.
            var frm = (Formulario)dgvFormularios.CurrentRow.DataBoundItem;

            formulario.InicializarFormulario(frmABMFormularios.FormMode.eliminar, frm);
            formulario.ShowDialog();

            //Forzamos el evento Click para actualizar el DataGridView.
            btnConsultar_Click(sender, e);
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvFormularios.ColumnCount = 3;
            dgvFormularios.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvFormularios.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvFormularios.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvFormularios.Columns[0].Name = "ID Formulario";
            dgvFormularios.Columns[0].DataPropertyName = "id_formulario";
            // Definimos el ancho de la columna.            

            dgvFormularios.Columns[1].Name = "Formulario";
            dgvFormularios.Columns[1].DataPropertyName = "nombre";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvFormularios.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvFormularios.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

       
    }
}
