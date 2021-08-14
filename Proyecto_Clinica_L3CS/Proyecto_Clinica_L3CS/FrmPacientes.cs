using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Clinica_L3CS
{
    public partial class FrmPacientes : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
        }

        FrmCitas FormCitas;

        private string Operacion = string.Empty;

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            ListadePacientes();
            LlenarTipoSangre();
        }

        private void LlenarTipoSangre()
        {
            BaseDatos bd = new BaseDatos();
            TipoSangreComboBox.DataSource = bd.CargarTiposSangre();
            TipoSangreComboBox.DisplayMember = "TIPO_SANGRE";
            TipoSangreComboBox.ValueMember = "ID";
        }

        private void ListadePacientes()
        {
            BaseDatos bd = new BaseDatos();
            PacientesDataGridView.DataSource = bd.ListarPacientes();
        }

        private void HabilitarControles()
        {
            IdentidadTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            TelefonoTextBox.Enabled = true;
            DireccionTextBox.Enabled = true;
            EdadTextBox.Enabled = true;
            TipoSangreComboBox.Enabled = true;
            
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
            ModificarButton.Enabled = false;
        }

        private void desHabilitarControles()
        {
            IdentidadTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            TelefonoTextBox.Enabled = false;
            DireccionTextBox.Enabled = false;
            EdadTextBox.Enabled = false;
            TipoSangreComboBox.Enabled = false;

            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
            ModificarButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            IdentidadTextBox.Clear();
            NombreTextBox.Clear();
            TelefonoTextBox.Clear();
            DireccionTextBox.Clear();
            EdadTextBox.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Operacion = "Nuevo";
            HabilitarControles();
            IdentidadTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdentidadTextBox.Text))
            {
                errorProvider1.SetError(IdentidadTextBox, "Ingrese un numero de Identidad");
                IdentidadTextBox.Focus();
            }
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese un Nombre");
                NombreTextBox.Focus();
            }
            if (string.IsNullOrEmpty(TelefonoTextBox.Text))
            {
                errorProvider1.SetError(TelefonoTextBox, "Ingrese un Numero de Telefono");
                TelefonoTextBox.Focus();
            }
            if (string.IsNullOrEmpty(DireccionTextBox.Text))
            {
                errorProvider1.SetError(DireccionTextBox, "Ingrese una Direccion valida");
                DireccionTextBox.Focus();
            }
            if (string.IsNullOrEmpty(EdadTextBox.Text))
            {
                errorProvider1.SetError(EdadTextBox, "Ingrese una edad valida");
                EdadTextBox.Focus();
            }

            BaseDatos bd = new BaseDatos();

            if (Operacion == "Nuevo")
            {
                bool agregar = bd.AgregarPaciente(IdentidadTextBox.Text, NombreTextBox.Text, Convert.ToInt32(TelefonoTextBox.Text), DireccionTextBox.Text, Convert.ToInt32(EdadTextBox.Text), Convert.ToInt32(TipoSangreComboBox.SelectedValue));
                LimpiarControles();
                ListadePacientes();
                desHabilitarControles();
            }
            else if (Operacion == "Modificar")
            {
                bool modifica = bd.AgregarPaciente(IdentidadTextBox.Text, NombreTextBox.Text, Convert.ToInt32(TelefonoTextBox.Text), DireccionTextBox.Text, Convert.ToInt32(EdadTextBox.Text), Convert.ToInt32(TipoSangreComboBox.SelectedValue));
                LimpiarControles();
                ListadePacientes();
                desHabilitarControles();
            }



        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            Operacion = "Modificar";
            if (PacientesDataGridView.SelectedCells.Count > 0)
            {
                IdentidadTextBox.Text = PacientesDataGridView.CurrentRow.Cells["IDENTIDAD"].Value.ToString();
                NombreTextBox.Text = PacientesDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                TelefonoTextBox.Text = PacientesDataGridView.CurrentRow.Cells["TELEFONO"].Value.ToString();
                DireccionTextBox.Text = PacientesDataGridView.CurrentRow.Cells["DIRECCION"].Value.ToString();
                EdadTextBox.Text = PacientesDataGridView.CurrentRow.Cells["EDAD"].Value.ToString();
                TipoSangreComboBox.Text = PacientesDataGridView.CurrentRow.Cells["TIPO_SANGRE"].Value.ToString();

                HabilitarControles();
                NombreTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Paciente");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (PacientesDataGridView.SelectedRows.Count > 0)
            {
                BaseDatos bd = new BaseDatos();
                bool eliminar = bd.EliminarPaciente(PacientesDataGridView.CurrentRow.Cells[0].Value.ToString());
                ListadePacientes();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor");
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            desHabilitarControles();
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EdadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HacerCitaButton_Click(object sender, EventArgs e)
        {
            if (FormCitas == null)
            {
                FormCitas = new FrmCitas();
                FormCitas.FormClosed += FormCitas_FormClosed;
                FormCitas.Show();

            }
            else
            {
                FormCitas.Activate();
            }
        }

        private void FormCitas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCitas = null;
        }
    }
}
