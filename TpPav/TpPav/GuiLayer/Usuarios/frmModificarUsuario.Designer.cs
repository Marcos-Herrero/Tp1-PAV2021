
namespace TpPav
{
    partial class frmModificar
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::TpPav.Properties.Resources.grabar3;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(218, 363);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 50);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = global::TpPav.Properties.Resources.salir;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmar.Location = new System.Drawing.Point(293, 363);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(56, 50);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.cboPerfil);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPerfil);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(308, 325);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Usuario";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(97, 263);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(177, 28);
            this.cboEstado.TabIndex = 24;
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(97, 171);
            this.cboPerfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(177, 28);
            this.cboPerfil.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 219);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 27);
            this.txtEmail.TabIndex = 22;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(97, 44);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(177, 27);
            this.txtId.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 127);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 27);
            this.txtPassword.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 85);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 27);
            this.txtNombre.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(26, 226);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 20);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerfil.Location = new System.Drawing.Point(36, 179);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(45, 20);
            this.lblPerfil.TabIndex = 16;
            this.lblPerfil.Text = "Perfil:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstado.Location = new System.Drawing.Point(24, 271);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 20);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Location = new System.Drawing.Point(54, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "ID:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPass.Location = new System.Drawing.Point(8, 134);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(73, 20);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Password:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(14, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TpPav.Properties.Resources.prueba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 424);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmModificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.ComboBox cboEstado;
        public System.Windows.Forms.ComboBox cboPerfil;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtNombre;
    }
}