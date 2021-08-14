using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Clinica_L3CS
{
    public partial class FrmLogin : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == "")
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese el Usuario");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.SetError(UsuarioTextBox, "");

            if (ContraseñaTextBox.Text == "")
            {
                errorProvider1.SetError(ContraseñaTextBox, "Ingrese la Contraseña");
                ContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.SetError(ContraseñaTextBox, "");

            BaseDatos conexion = new BaseDatos();

            if (conexion.ValidarUsuario(UsuarioTextBox.Text, ContraseñaTextBox.Text))
            {
                FrmPrincipal formulario = new FrmPrincipal();
                formulario.CodigoUsuario = UsuarioTextBox.Text;
                this.Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }






        }
    }
}
