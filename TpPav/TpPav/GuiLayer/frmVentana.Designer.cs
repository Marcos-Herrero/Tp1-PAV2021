
namespace TpPav.GuiLayer
{
    partial class frmVentana
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.formulariosToolStripMenuItem,
            this.permisosToolStripMenuItem,
            this.soporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem1});
            this.formulariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formulariosToolStripMenuItem.Text = "Perfiles";
            // 
            // formulariosToolStripMenuItem1
            // 
            this.formulariosToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.formulariosToolStripMenuItem1.Name = "formulariosToolStripMenuItem1";
            this.formulariosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.formulariosToolStripMenuItem1.Text = "Administrar Perfiles";
            this.formulariosToolStripMenuItem1.Click += new System.EventHandler(this.formulariosToolStripMenuItem1_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPermisosToolStripMenuItem});
            this.permisosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // administrarPermisosToolStripMenuItem
            // 
            this.administrarPermisosToolStripMenuItem.Name = "administrarPermisosToolStripMenuItem";
            this.administrarPermisosToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.administrarPermisosToolStripMenuItem.Text = "Administrar Permisos";
            this.administrarPermisosToolStripMenuItem.Click += new System.EventHandler(this.administrarPermisosToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem3,
            this.usuariosToolStripMenuItem});
            this.soporteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // formulariosToolStripMenuItem3
            // 
            this.formulariosToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuariosToolStripMenuItem});
            this.formulariosToolStripMenuItem3.Name = "formulariosToolStripMenuItem3";
            this.formulariosToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.formulariosToolStripMenuItem3.Text = "Formularios";
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar formularios";
            this.administrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administrarUsuariosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuarios});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // administrarUsuarios
            // 
            this.administrarUsuarios.Enabled = false;
            this.administrarUsuarios.Name = "administrarUsuarios";
            this.administrarUsuarios.Size = new System.Drawing.Size(227, 26);
            this.administrarUsuarios.Text = "Administrar usuarios";
            this.administrarUsuarios.Click += new System.EventHandler(this.administrarUsuariosToolStripMenuItem1_Click);
            // 
            // frmVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TpPav.Properties.Resources.prueba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVentana";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVentana_FormClosing);
            this.Load += new System.EventHandler(this.frmVentana_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuarios;
    }
}