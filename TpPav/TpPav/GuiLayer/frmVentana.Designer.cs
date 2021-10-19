
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
            this.usuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarFormulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.usuariosMenu,
            this.formulariosToolStripMenuItem,
            this.formulariosToolStripMenuItem2,
            this.permisosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1142, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // usuariosMenu
            // 
            this.usuariosMenu.AccessibleName = "";
            this.usuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeUsuariosToolStripMenuItem});
            this.usuariosMenu.Name = "usuariosMenu";
            this.usuariosMenu.Size = new System.Drawing.Size(96, 29);
            this.usuariosMenu.Text = "Usuarios";
            // 
            // controlDeUsuariosToolStripMenuItem
            // 
            this.controlDeUsuariosToolStripMenuItem.Name = "controlDeUsuariosToolStripMenuItem";
            this.controlDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.controlDeUsuariosToolStripMenuItem.Text = "Control de Usuarios";
            this.controlDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.controlDeUsuariosToolStripMenuItem_Click);
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem1});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.formulariosToolStripMenuItem.Text = "Perfiles";
            // 
            // formulariosToolStripMenuItem1
            // 
            this.formulariosToolStripMenuItem1.Name = "formulariosToolStripMenuItem1";
            this.formulariosToolStripMenuItem1.Size = new System.Drawing.Size(266, 34);
            this.formulariosToolStripMenuItem1.Text = "Administrar Perfiles";
            this.formulariosToolStripMenuItem1.Click += new System.EventHandler(this.formulariosToolStripMenuItem1_Click);
            // 
            // formulariosToolStripMenuItem2
            // 
            this.formulariosToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarFormulariosToolStripMenuItem});
            this.formulariosToolStripMenuItem2.Name = "formulariosToolStripMenuItem2";
            this.formulariosToolStripMenuItem2.Size = new System.Drawing.Size(122, 29);
            this.formulariosToolStripMenuItem2.Text = "Formularios";
            // 
            // administrarFormulariosToolStripMenuItem
            // 
            this.administrarFormulariosToolStripMenuItem.Name = "administrarFormulariosToolStripMenuItem";
            this.administrarFormulariosToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.administrarFormulariosToolStripMenuItem.Text = "Administrar Formularios";
            this.administrarFormulariosToolStripMenuItem.Click += new System.EventHandler(this.administrarFormulariosToolStripMenuItem_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPermisosToolStripMenuItem});
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // administrarPermisosToolStripMenuItem
            // 
            this.administrarPermisosToolStripMenuItem.Name = "administrarPermisosToolStripMenuItem";
            this.administrarPermisosToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.administrarPermisosToolStripMenuItem.Text = "Administrar Permisos";
            this.administrarPermisosToolStripMenuItem.Click += new System.EventHandler(this.administrarPermisosToolStripMenuItem_Click);
            // 
            // frmVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 750);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVentana";
            this.Text = "frmVentana";
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
        private System.Windows.Forms.ToolStripMenuItem usuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem controlDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem administrarFormulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPermisosToolStripMenuItem;
    }
}