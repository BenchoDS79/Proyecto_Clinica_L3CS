namespace Proyecto_Clinica_L3CS
{
    partial class FrmBuscarPaciente
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
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.BuscarPacienteDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarPacienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(484, 21);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(82, 28);
            this.AceptarButton.TabIndex = 0;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(580, 21);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(82, 28);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(68, 26);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(380, 20);
            this.NombreTextBox.TabIndex = 3;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            this.NombreTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NombreTextBox_KeyUp);
            // 
            // BuscarPacienteDataGridView
            // 
            this.BuscarPacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuscarPacienteDataGridView.Location = new System.Drawing.Point(2, 70);
            this.BuscarPacienteDataGridView.Name = "BuscarPacienteDataGridView";
            this.BuscarPacienteDataGridView.Size = new System.Drawing.Size(673, 190);
            this.BuscarPacienteDataGridView.TabIndex = 4;
            // 
            // FrmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 259);
            this.Controls.Add(this.BuscarPacienteDataGridView);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmBuscarPaciente";
            this.Text = " Buscar Paciente";
            this.Load += new System.EventHandler(this.FrmBuscarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuscarPacienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.DataGridView BuscarPacienteDataGridView;
    }
}