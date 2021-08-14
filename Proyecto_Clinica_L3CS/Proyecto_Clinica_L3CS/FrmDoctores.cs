using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Clinica_L3CS
{
    public partial class FrmDoctores : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmDoctores()
        {
            InitializeComponent();
        }

        private string Operacion = string.Empty;

        private void FrmDoctores_Load(object sender, EventArgs e)
        {
            LlenarCategorias();
            ListaDoctores();
        }

        private void LlenarCategorias()
        {
            BaseDatos BD = new BaseDatos();
            EspecialidadComboBox.DataSource = BD.CargarEspecialidades();
            EspecialidadComboBox.DisplayMember = "ESPECIALIDAD";
            EspecialidadComboBox.ValueMember = "ID";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Operacion = "Nuevo";
            HabilitarControles();
            NumeroColTextBox.Focus();
        }

        private void HabilitarControles()
        {
            NombreTextBox.Enabled = true;
            IdentidadTextBox.Enabled = true;
            EspecialidadComboBox.Enabled = true;
            NumeroColTextBox.Enabled = true;
            TelefonoTextBox.Enabled = true;

            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
            ModificarButton.Enabled = false;
        }

        private void desHabilitarControles()
        {
            NombreTextBox.Enabled = false;
            IdentidadTextBox.Enabled = false;
            EspecialidadComboBox.Enabled = false;
            NumeroColTextBox.Enabled = false;
            TelefonoTextBox.Enabled = false;

            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
            ModificarButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            NombreTextBox.Clear();
            IdentidadTextBox.Clear();
            NumeroColTextBox.Clear();
            TelefonoTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NumeroColTextBox.Text))
            {
                errorProvider1.SetError(NumeroColTextBox, "Ingrese un Codigo");
                NumeroColTextBox.Focus();
            }
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese un Nombre");
                NombreTextBox.Focus();
            }
            if (string.IsNullOrEmpty(IdentidadTextBox.Text))
            {
                errorProvider1.SetError(IdentidadTextBox, "Ingrese un Numero de Identidad");
                IdentidadTextBox.Focus();
            }
            if (string.IsNullOrEmpty(TelefonoTextBox.Text))
            {
                errorProvider1.SetError(TelefonoTextBox, "Ingrese un Telefono");
                TelefonoTextBox.Focus();
            }



            BaseDatos bd = new BaseDatos();

            if (Operacion == "Nuevo")
            {
                bool agregar = bd.AgregarDoctor(NumeroColTextBox.Text, NombreTextBox.Text, IdentidadTextBox.Text, Convert.ToInt32(TelefonoTextBox.Text), Convert.ToInt32(EspecialidadComboBox.SelectedValue));
                LimpiarControles();
                ListaDoctores();
                desHabilitarControles();
            }
            else if (Operacion == "Modificar")
            {
                bool modifica = bd.EditarDoctor(NumeroColTextBox.Text, NombreTextBox.Text, IdentidadTextBox.Text, Convert.ToInt32(TelefonoTextBox.Text), Convert.ToInt32(EspecialidadComboBox.SelectedValue));
                LimpiarControles();
                ListaDoctores();
                desHabilitarControles();
            }
        }

        private void ListaDoctores()
        {
            BaseDatos bd = new BaseDatos();
            DoctoresDataGridView.DataSource = bd.ListarDoctores();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            desHabilitarControles();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            Operacion = "Modificar";
            if (DoctoresDataGridView.SelectedCells.Count > 0)
            {
                NumeroColTextBox.Text = DoctoresDataGridView.CurrentRow.Cells["CODIGO"].Value.ToString();
                NombreTextBox.Text = DoctoresDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                IdentidadTextBox.Text = DoctoresDataGridView.CurrentRow.Cells["IDENTIDAD"].Value.ToString();
                TelefonoTextBox.Text = DoctoresDataGridView.CurrentRow.Cells["TELEFONO"].Value.ToString();
                EspecialidadComboBox.Text = DoctoresDataGridView.CurrentRow.Cells["ESPECIALIDAD"].Value.ToString();

                HabilitarControles();
                NumeroColTextBox.Enabled = false;
                NombreTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor");
            }

            
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (DoctoresDataGridView.SelectedRows.Count > 0)
            {
                BaseDatos bd = new BaseDatos();
                bool eliminar = bd.EliminarDoctor(DoctoresDataGridView.CurrentRow.Cells[0].Value.ToString());
                ListaDoctores();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor");
            }

        }

        private void IdentidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void EspecialidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
     