using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Clinica_L3CS
{
    public partial class FrmUsuarios : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        BaseDatos bd = new BaseDatos();

        private string operacion = string.Empty;
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListadeUsuarios();
        }

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            ContraseñaTextBox.Enabled = true;
            ActivoCheckBox.Enabled = true;

            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
            ModificarButton.Enabled = false;
            EliminarButton.Enabled = false;
        }

        private void desHabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            ContraseñaTextBox.Enabled = false;
            ActivoCheckBox.Enabled = false;

            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
            ModificarButton.Enabled = true;
            EliminarButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Clear();
            ContraseñaTextBox.Clear();
            ActivoCheckBox.Checked = false;

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
            CodigoTextBox.Focus();
        }

        private void ListadeUsuarios()
        {
            UsuariosDataGridView.DataSource = bd.ListaUsuarios();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                bool insertar = bd.AgregarUsuario(CodigoTextBox.Text, NombreTextBox.Text, ContraseñaTextBox.Text, ActivoCheckBox.Checked);
                ListadeUsuarios();
                LimpiarControles();
                desHabilitarControles();
            }
            else if (operacion == "Modificar")
            {
                bool modifica = bd.EditarUsuario(CodigoTextBox.Text, NombreTextBox.Text, ContraseñaTextBox.Text, ActivoCheckBox.Checked);
                LimpiarControles();
                ListadeUsuarios();
                desHabilitarControles();
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (UsuariosDataGridView.SelectedCells.Count > 0)
            {
                CodigoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["CODIGO"].Value.ToString();
                NombreTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                ActivoCheckBox.Checked = Convert.ToBoolean(UsuariosDataGridView.CurrentRow.Cells["ESTAACTIVO"].Value.ToString());
                HabilitarControles();

                CodigoTextBox.Enabled = false;
                NombreTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            operacion = "Eliminar";
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = bd.EliminarUsuario(UsuariosDataGridView.CurrentRow.Cells["CODIGO"].Value.ToString());
                ListadeUsuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario");
            }
        }


    }
}
