
namespace TpPav
{
    partial class frmActualizar
    {
        //cambio para que se suba en el repositorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.dpbDetalle = new System.Windows.Forms.GroupBox();
            this._btnCancelar = new System.Windows.Forms.Button();
            this._btnQuitar = new System.Windows.Forms.Button();
            this._btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.NroForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lblFormulario = new System.Windows.Forms.Label();
            this._cboFormularios = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.dpbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(60, 38);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(45, 20);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "Perfil:";
            // 
            // dpbDetalle
            // 
            this.dpbDetalle.Controls.Add(this._btnCancelar);
            this.dpbDetalle.Controls.Add(this._btnQuitar);
            this.dpbDetalle.Controls.Add(this._btnAgregar);
            this.dpbDetalle.Controls.Add(this.dgvDetalle);
            this.dpbDetalle.Controls.Add(this._lblFormulario);
            this.dpbDetalle.Controls.Add(this._cboFormularios);
            this.dpbDetalle.Enabled = false;
            this.dpbDetalle.Location = new System.Drawing.Point(16, 94);
            this.dpbDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpbDetalle.Name = "dpbDetalle";
            this.dpbDetalle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpbDetalle.Size = new System.Drawing.Size(1036, 634);
            this.dpbDetalle.TabIndex = 7;
            this.dpbDetalle.TabStop = false;
            this.dpbDetalle.Text = "Detalle Formularios";
            // 
            // _btnCancelar
            // 
            this._btnCancelar.Image = global::TpPav.Properties.Resources.cancelar3;
            this._btnCancelar.Location = new System.Drawing.Point(221, 91);
            this._btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(51, 55);
            this._btnCancelar.TabIndex = 7;
            this._btnCancelar.UseVisualStyleBackColor = true;
            this._btnCancelar.Click += new System.EventHandler(this._btnCancelar_Click);
            // 
            // _btnQuitar
            // 
            this._btnQuitar.Image = global::TpPav.Properties.Resources.eliminar;
            this._btnQuitar.Location = new System.Drawing.Point(162, 91);
            this._btnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnQuitar.Name = "_btnQuitar";
            this._btnQuitar.Size = new System.Drawing.Size(51, 55);
            this._btnQuitar.TabIndex = 6;
            this._btnQuitar.UseVisualStyleBackColor = true;
            this._btnQuitar.Click += new System.EventHandler(this._btnQuitar_Click);
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Image = global::TpPav.Properties.Resources.agregar;
            this._btnAgregar.Location = new System.Drawing.Point(106, 91);
            this._btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(48, 55);
            this._btnAgregar.TabIndex = 5;
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroForm,
            this.Nombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.Location = new System.Drawing.Point(18, 178);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle.RowHeadersWidth = 70;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(312, 388);
            this.dgvDetalle.TabIndex = 7;
            // 
            // NroForm
            // 
            this.NroForm.DataPropertyName = "NroForm";
            this.NroForm.HeaderText = "Nro. Form";
            this.NroForm.MinimumWidth = 6;
            this.NroForm.Name = "NroForm";
            this.NroForm.ReadOnly = true;
            this.NroForm.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Formulario";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 70;
            // 
            // _lblFormulario
            // 
            this._lblFormulario.AutoSize = true;
            this._lblFormulario.Location = new System.Drawing.Point(11, 49);
            this._lblFormulario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblFormulario.Name = "_lblFormulario";
            this._lblFormulario.Size = new System.Drawing.Size(84, 20);
            this._lblFormulario.TabIndex = 1;
            this._lblFormulario.Text = "Formulario:";
            // 
            // _cboFormularios
            // 
            this._cboFormularios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboFormularios.FormattingEnabled = true;
            this._cboFormularios.Location = new System.Drawing.Point(96, 40);
            this._cboFormularios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._cboFormularios.Name = "_cboFormularios";
            this._cboFormularios.Size = new System.Drawing.Size(182, 28);
            this._cboFormularios.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::TpPav.Properties.Resources.nuevo1;
            this.btnNuevo.Location = new System.Drawing.Point(16, 760);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 55);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::TpPav.Properties.Resources.grabar3;
            this.btnGrabar.Location = new System.Drawing.Point(124, 761);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 54);
            this.btnGrabar.TabIndex = 14;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TpPav.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(277, 760);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 54);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtPerfil
            // 
            this.txtPerfil.Enabled = false;
            this.txtPerfil.Location = new System.Drawing.Point(112, 31);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(182, 27);
            this.txtPerfil.TabIndex = 16;
            // 
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 871);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dpbDetalle);
            this.Controls.Add(this.lblPerfil);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Perfil";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.dpbDetalle.ResumeLayout(false);
            this.dpbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.GroupBox dpbDetalle;
        private System.Windows.Forms.Button _btnCancelar;
        private System.Windows.Forms.Button _btnQuitar;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label _lblFormulario;
        private System.Windows.Forms.ComboBox _cboFormularios;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.TextBox txtPerfil;
    }
}