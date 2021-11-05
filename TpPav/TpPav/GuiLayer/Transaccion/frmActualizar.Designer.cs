
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
            this.lblPerfil = new System.Windows.Forms.Label();
            this.dpbDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this._btnQuitar = new System.Windows.Forms.Button();
            this._btnAgregar = new System.Windows.Forms.Button();
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
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerfil.Location = new System.Drawing.Point(59, 37);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(45, 20);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "Perfil:";
            // 
            // dpbDetalle
            // 
            this.dpbDetalle.BackColor = System.Drawing.Color.Transparent;
            this.dpbDetalle.Controls.Add(this.dgvDetalle);
            this.dpbDetalle.Controls.Add(this._btnQuitar);
            this.dpbDetalle.Controls.Add(this._btnAgregar);
            this.dpbDetalle.Controls.Add(this._lblFormulario);
            this.dpbDetalle.Controls.Add(this._cboFormularios);
            this.dpbDetalle.Enabled = false;
            this.dpbDetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dpbDetalle.Location = new System.Drawing.Point(16, 93);
            this.dpbDetalle.Margin = new System.Windows.Forms.Padding(5);
            this.dpbDetalle.Name = "dpbDetalle";
            this.dpbDetalle.Padding = new System.Windows.Forms.Padding(5);
            this.dpbDetalle.Size = new System.Drawing.Size(442, 585);
            this.dpbDetalle.TabIndex = 7;
            this.dpbDetalle.TabStop = false;
            this.dpbDetalle.Text = "Detalle Formularios";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(71, 120);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 25;
            this.dgvDetalle.Size = new System.Drawing.Size(302, 421);
            this.dgvDetalle.TabIndex = 8;
            // 
            // _btnQuitar
            // 
            this._btnQuitar.Image = global::TpPav.Properties.Resources.eliminar;
            this._btnQuitar.Location = new System.Drawing.Point(372, 26);
            this._btnQuitar.Margin = new System.Windows.Forms.Padding(5);
            this._btnQuitar.Name = "_btnQuitar";
            this._btnQuitar.Size = new System.Drawing.Size(51, 55);
            this._btnQuitar.TabIndex = 6;
            this._btnQuitar.UseVisualStyleBackColor = true;
            this._btnQuitar.Click += new System.EventHandler(this._btnQuitar_Click);
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Image = global::TpPav.Properties.Resources.agregar;
            this._btnAgregar.Location = new System.Drawing.Point(304, 26);
            this._btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(48, 55);
            this._btnAgregar.TabIndex = 5;
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // _lblFormulario
            // 
            this._lblFormulario.AutoSize = true;
            this._lblFormulario.Location = new System.Drawing.Point(11, 49);
            this._lblFormulario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this._cboFormularios.Margin = new System.Windows.Forms.Padding(5);
            this._cboFormularios.Name = "_cboFormularios";
            this._cboFormularios.Size = new System.Drawing.Size(182, 28);
            this._cboFormularios.TabIndex = 0;
            this._cboFormularios.Click += new System.EventHandler(this._cboFormularios_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::TpPav.Properties.Resources.nuevo1;
            this.btnNuevo.Location = new System.Drawing.Point(14, 688);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 52);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::TpPav.Properties.Resources.grabar3;
            this.btnGrabar.Location = new System.Drawing.Point(112, 688);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(72, 52);
            this.btnGrabar.TabIndex = 14;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TpPav.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(388, 688);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 53);
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
            this.txtPerfil.TextChanged += new System.EventHandler(this.txtPerfil_TextChanged);
            // 
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TpPav.Properties.Resources.prueba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 759);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dpbDetalle);
            this.Controls.Add(this.lblPerfil);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Perfil";
            this.Load += new System.EventHandler(this.frmActualizar_Load);
            this.dpbDetalle.ResumeLayout(false);
            this.dpbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.GroupBox dpbDetalle;
        private System.Windows.Forms.Button _btnQuitar;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.Label _lblFormulario;
        private System.Windows.Forms.ComboBox _cboFormularios;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.DataGridView dgvDetalle;
    }
}