using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Clinica_L3CS
{
    public partial class FrmPrincipal : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        FrmUsuarios FormUsuarios;
        FrmDoctores FormDoctores;
        FrmPacientes FormPacientes;
        FrmCitas FormCitas;
        FrmConsultas FormConsultas;
        FrmFactura FormFactura;

        public string CodigoUsuario;

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (FormUsuarios == null)
            {
                FormUsuarios = new FrmUsuarios();
                FormUsuarios.MdiParent = this;
                FormUsuarios.FormClosed += FormUsuarios_FormClosed;
                FormUsuarios.Show();
            }
            else
            {
                FormUsuarios.Activate();
            }
        }

        private void FormUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUsuarios = null;
        }

        private void DoctoresToolStripButton_Click(object sender, EventArgs e)
        {
            if (FormDoctores == null)
            {
                FormDoctores = new FrmDoctores();
                FormDoctores.MdiParent = this;
                FormDoctores.FormClosed += FormDoctores_FormClosed;
                FormDoctores.Show();
            }

            else
            {
                FormDoctores.Activate();
            }
        }

        private void FormDoctores_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDoctores = null;
        }

        private void PacientesToolStripButton_Click(object sender, EventArgs e)
        {
            if (FormPacientes == null)
            {
                FormPacientes = new FrmPacientes();
                FormPacientes.MdiParent = this;
                FormPacientes.FormClosed += FormPacientes_FormClosed;
                FormPacientes.Show();
            }
            else
            {
                FormPacientes.Activate();
            }
        }

        private void FormPacientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPacientes = null;
        }

        private void CitasToolStripButton_Click(object sender, EventArgs e)
        {
            if (FormCitas == null)
            {
                FormCitas = new FrmCitas();
                FormCitas.MdiParent = this;
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

        private void ConsultasToolStripButton_Click(object sender, EventArgs e)
        {
            if (FormConsultas == null)
            {
                FormConsultas = new FrmConsultas();
                FormConsultas.MdiParent = this;
                FormConsultas.FormClosed += FormConsultas_FormClosed;
                FormConsultas.Show();
            }
            else
            {
                FormConsultas.Activate();
            }
        }

        private void FormConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormConsultas = null;
        }

        private void FacturaToolStripButton_Click(object sender, EventArgs e)
        {
            if (FormFactura == null)
            {
                FormFactura = new FrmFactura();
                FormFactura.CodigoUsuario = CodigoUsuario;
                FormFactura.MdiParent = this;
                FormFactura.FormClosed += FormFactura_FormClosed;
                FormFactura.Show();
            }
            else
            {
                FormFactura.Activate();
            }
        }

        private void FormFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormFactura = null;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("¿Desea salir del Sistema?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No))
            {
                e.Cancel = true;
            }
 
        }



    }
}
