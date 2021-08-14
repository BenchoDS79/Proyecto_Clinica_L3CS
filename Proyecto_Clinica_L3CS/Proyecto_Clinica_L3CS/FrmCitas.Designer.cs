namespace Proyecto_Clinica_L3CS
{
    partial class FrmCitas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EspecialidadComboBox = new System.Windows.Forms.ComboBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DoctorTextBox = new System.Windows.Forms.TextBox();
            this.NuevaButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doctor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 193);
            this.dataGridView1.TabIndex = 4;
            // 
            // EspecialidadComboBox
            // 
            this.EspecialidadComboBox.FormattingEnabled = true;
            this.EspecialidadComboBox.Location = new System.Drawing.Point(313, 25);
            this.EspecialidadComboBox.Name = "EspecialidadComboBox";
            this.EspecialidadComboBox.Size = new System.Drawing.Size(156, 21);
            this.EspecialidadComboBox.TabIndex = 5;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(19, 25);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(156, 20);
            this.NombreTextBox.TabIndex = 6;
            // 
            // CitaDateTimePicker
            // 
            this.CitaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CitaDateTimePicker.Location = new System.Drawing.Point(22, 87);
            this.CitaDateTimePicker.Name = "CitaDateTimePicker";
            this.CitaDateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.CitaDateTimePicker.TabIndex = 7;
            // 
            // DoctorTextBox
            // 
            this.DoctorTextBox.Location = new System.Drawing.Point(313, 87);
            this.DoctorTextBox.Name = "DoctorTextBox";
            this.DoctorTextBox.Size = new System.Drawing.Size(156, 20);
            this.DoctorTextBox.TabIndex = 8;
            // 
            // NuevaButton
            // 
            this.NuevaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaButton.Location = new System.Drawing.Point(19, 131);
            this.NuevaButton.Name = "NuevaButton";
            this.NuevaButton.Size = new System.Drawing.Size(93, 34);
            this.NuevaButton.TabIndex = 9;
            this.NuevaButton.Text = "Nueva Cita";
            this.NuevaButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(138, 131);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 34);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar Cita";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(376, 131);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(93, 34);
            this.CancelarButton.TabIndex = 11;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(257, 131);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(93, 34);
            this.ModificarButton.TabIndex = 12;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(183, 24);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(97, 23);
            this.BuscarButton.TabIndex = 13;
            this.BuscarButton.Text = "Buscar Paciente";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 397);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevaButton);
            this.Controls.Add(this.DoctorTextBox);
            this.Controls.Add(this.CitaDateTimePicker);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.EspecialidadComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCitas";
            this.Text = "Citas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox EspecialidadComboBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.DateTimePicker CitaDateTimePicker;
        private System.Windows.Forms.TextBox DoctorTextBox;
        private System.Windows.Forms.Button NuevaButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button BuscarButton;
    }
}