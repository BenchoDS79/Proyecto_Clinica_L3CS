using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Clinica_L3CS
{
    public partial class FrmCitas : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }

        public string CodigoPaciente;
 
        BaseDatos bd = new BaseDatos();


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            FrmBuscarPaciente formulario = new FrmBuscarPaciente();
            formulario.ShowDialog();
            NombreTextBox.Text = formulario.Nombre;
        }

        private void LlenarCategorias()
        {
            BaseDatos BD = new BaseDatos();
            EspecialidadCitaComboBox.DataSource = BD.CargarEspecialidades();
            EspecialidadCitaComboBox.DisplayMember = "ESPECIALIDAD";
            EspecialidadCitaComboBox.ValueMember = "ID";
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            LlenarCategorias();
        }
    }
}
