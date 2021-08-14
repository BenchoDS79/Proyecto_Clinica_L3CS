using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Clinica_L3CS
{
    public partial class FrmBuscarPaciente : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmBuscarPaciente()
        {
            InitializeComponent();
        }
        
        BaseDatos bd = new BaseDatos();

       public string Nombre;

        private void FrmBuscarPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                BuscarPacienteDataGridView.DataSource = bd.ListarPacientes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void NombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPacienteDataGridView.DataSource = bd.SeleccionarPacientesParaCitaPorNombre(NombreTextBox.Text);
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (BuscarPacienteDataGridView.RowCount > 0)
            {
                if (BuscarPacienteDataGridView.SelectedRows.Count > 0)
                {
                    Nombre = BuscarPacienteDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    this.Close();
                }

            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
