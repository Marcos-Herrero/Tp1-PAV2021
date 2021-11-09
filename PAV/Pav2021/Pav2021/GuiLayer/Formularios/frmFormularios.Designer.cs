namespace Pav2021.GUILayer.Formularioes
{
    partial class frmFormularios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvFormularios = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboFormularios = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cboIdFormulario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormularios)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Image = global::Pav2021.Properties.Resources.eliminar;
            this.btnQuitar.Location = new System.Drawing.Point(139, 509);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(53, 62);
            this.btnQuitar.TabIndex = 11;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvFormularios
            // 
            this.dgvFormularios.AllowUserToAddRows = false;
            this.dgvFormularios.AllowUserToDeleteRows = false;
            this.dgvFormularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormularios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFormularios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFormularios.Location = new System.Drawing.Point(4, 182);
            this.dgvFormularios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFormularios.Name = "dgvFormularios";
            this.dgvFormularios.ReadOnly = true;
            this.dgvFormularios.RowHeadersWidth = 51;
            this.dgvFormularios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormularios.Size = new System.Drawing.Size(543, 295);
            this.dgvFormularios.TabIndex = 8;
            this.dgvFormularios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Pav2021.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(513, 509);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 62);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::Pav2021.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(77, 509);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(53, 62);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Pav2021.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(16, 509);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(53, 62);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(140, 118);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(71, 24);
            this.chkTodos.TabIndex = 2;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 38);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(101, 20);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id Formulario:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = global::Pav2021.Properties.Resources.BUSCAR01;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.Location = new System.Drawing.Point(431, 84);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(70, 40);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboFormularios
            // 
            this.cboFormularios.FormattingEnabled = true;
            this.cboFormularios.Location = new System.Drawing.Point(140, 70);
            this.cboFormularios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFormularios.Name = "cboFormularios";
            this.cboFormularios.Size = new System.Drawing.Size(240, 28);
            this.cboFormularios.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 78);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Formulario:";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiltros.Controls.Add(this.btnLimpiar);
            this.pnlFiltros.Controls.Add(this.cboIdFormulario);
            this.pnlFiltros.Controls.Add(this.dgvFormularios);
            this.pnlFiltros.Controls.Add(this.chkTodos);
            this.pnlFiltros.Controls.Add(this.lblId);
            this.pnlFiltros.Controls.Add(this.btnConsultar);
            this.pnlFiltros.Controls.Add(this.cboFormularios);
            this.pnlFiltros.Controls.Add(this.lblNombre);
            this.pnlFiltros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFiltros.Location = new System.Drawing.Point(16, 18);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFiltros.Size = new System.Drawing.Size(551, 482);
            this.pnlFiltros.TabIndex = 8;
            this.pnlFiltros.TabStop = false;
            this.pnlFiltros.Text = "Filtros";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::Pav2021.Properties.Resources.Empty_Recycle_Bin_2000;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.Location = new System.Drawing.Point(431, 35);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 40);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // cboIdFormulario
            // 
            this.cboIdFormulario.FormattingEnabled = true;
            this.cboIdFormulario.Location = new System.Drawing.Point(140, 35);
            this.cboIdFormulario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboIdFormulario.Name = "cboIdFormulario";
            this.cboIdFormulario.Size = new System.Drawing.Size(240, 28);
            this.cboIdFormulario.TabIndex = 18;
            // 
            // frmFormularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pav2021.Properties.Resources.prueba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 605);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlFiltros);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormularios";
            this.Text = "Formularios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormularios)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.DataGridView dgvFormularios;
        internal System.Windows.Forms.DataGridViewTextBoxColumn columIdPerfil;
        internal System.Windows.Forms.DataGridViewTextBoxColumn columnPerfil;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.CheckBox chkTodos;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.ComboBox cboFormularios;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.GroupBox pnlFiltros;
        internal System.Windows.Forms.ComboBox cboIdFormulario;
        private System.Windows.Forms.Button btnLimpiar;
    }
}