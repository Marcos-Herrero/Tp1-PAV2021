namespace TpPav.GUILayer.Usuarios
{
    partial class frmABMPermisos
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblIdF = new System.Windows.Forms.Label();
            this.cboIdForm = new System.Windows.Forms.ComboBox();
            this.cboIdPerfil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(366, 140);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 35);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(241, 140);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 35);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(133, 90);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(78, 20);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Id Perfil(*):";
            // 
            // lblIdF
            // 
            this.lblIdF.AutoSize = true;
            this.lblIdF.Location = new System.Drawing.Point(97, 36);
            this.lblIdF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdF.Name = "lblIdF";
            this.lblIdF.Size = new System.Drawing.Size(114, 20);
            this.lblIdF.TabIndex = 31;
            this.lblIdF.Text = "Id Formulario(*)";
            // 
            // cboIdForm
            // 
            this.cboIdForm.FormattingEnabled = true;
            this.cboIdForm.Location = new System.Drawing.Point(218, 33);
            this.cboIdForm.Name = "cboIdForm";
            this.cboIdForm.Size = new System.Drawing.Size(255, 28);
            this.cboIdForm.TabIndex = 32;
            // 
            // cboIdPerfil
            // 
            this.cboIdPerfil.FormattingEnabled = true;
            this.cboIdPerfil.Location = new System.Drawing.Point(218, 82);
            this.cboIdPerfil.Name = "cboIdPerfil";
            this.cboIdPerfil.Size = new System.Drawing.Size(255, 28);
            this.cboIdPerfil.TabIndex = 33;
            // 
            // frmABMPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 199);
            this.Controls.Add(this.cboIdPerfil);
            this.Controls.Add(this.cboIdForm);
            this.Controls.Add(this.lblIdF);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.Label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmABMPermisos";
            this.Text = "Nuevo Permiso";
            this.Load += new System.EventHandler(this.frmABMUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lblIdF;
        private System.Windows.Forms.ComboBox cboIdForm;
        private System.Windows.Forms.ComboBox cboIdPerfil;
    }
}