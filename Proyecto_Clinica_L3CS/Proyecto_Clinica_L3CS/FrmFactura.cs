using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Clinica_L3CS
{
    public partial class FrmFactura : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        public string CodigoUsuario;
        int IdPaciente;
        BaseDatos bd = new BaseDatos();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = bd.GetNombreUsuario(CodigoUsuario);
        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdentidadMaskedEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var DatosPaciente = bd.GetPacienteParaFactura(IdentidadMaskedEditBox.Text);

                foreach (var item in DatosPaciente)
                {
                    IdPaciente = item.Key;
                    NombreTextBox.Text = item.Value;
                }
                
            }
            else
            {
                IdPaciente = 0;
                NombreTextBox.Clear();
                      
            }
        }
    }
}
