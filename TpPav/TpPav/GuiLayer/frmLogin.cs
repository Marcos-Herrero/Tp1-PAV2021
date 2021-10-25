using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TpPav.Entities;
using TpPav.BusinessLayer;

namespace TpPav.GuiLayer
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioService usuarioService;

        public string UsuarioLogueado { get; internal set; }

        public frmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validamos que se haya ingresado una password
            if ((txtContraseña.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var usr = usuarioService.ValidarUsuarioAdm(txtUsuario.Text, txtContraseña.Text);
            if (usr != null)
            {
                // Login OK
                UsuarioLogueado = usr.UsuarioNombre;
                if (UsuarioLogueado=="administrador")
                { 
                    frmVentana f= new frmVentana(true);                    
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    frmVentana f = new frmVentana(false);                    
                    f.ShowDialog();
                    this.Close();
                }                
                
                
            }
            else
            {
                //Limpiamos el campo password, para que el usuario intente ingresar un usuario distinto.
                txtContraseña.Text = "";
                // Enfocamos el cursor en el campo password para que el usuario complete sus datos.
                txtContraseña.Focus();
                //Mostramos un mensaje indicando que el usuario/password es invalido.
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



       }
}
