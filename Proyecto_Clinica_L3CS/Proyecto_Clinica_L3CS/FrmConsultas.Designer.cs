namespace Proyecto_Clinica_L3CS
{
    partial class FrmConsultas
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
            this.PacienteGroupBox = new System.Windows.Forms.GroupBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.DoctorGroupBox = new System.Windows.Forms.GroupBox();
            this.PreclinicaGroupBox = new System.Windows.Forms.GroupBox();
            this.EspecialidadTextBox1 = new System.Windows.Forms.TextBox();
            this.DocNombreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.GuardarBbutton = new System.Windows.Forms.Button();
            this.RectaButton = new System.Windows.Forms.Button();
            this.PacienteGroupBox.SuspendLayout();
            this.DoctorGroupBox.SuspendLayout();
            this.PreclinicaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identidad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // PacienteGroupBox
            // 
            this.PacienteGroupBox.Controls.Add(this.IdentidadTextBox);
            this.PacienteGroupBox.Controls.Add(this.EdadTextBox);
            this.PacienteGroupBox.Controls.Add(this.NombreTextBox);
            this.PacienteGroupBox.Controls.Add(this.label1);
            this.PacienteGroupBox.Controls.Add(this.label3);
            this.PacienteGroupBox.Controls.Add(this.label2);
            this.PacienteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacienteGroupBox.Location = new System.Drawing.Point(16, 15);
            this.PacienteGroupBox.Name = "PacienteGroupBox";
            this.PacienteGroupBox.Size = new System.Drawing.Size(598, 76);
            this.PacienteGroupBox.TabIndex = 5;
            this.PacienteGroupBox.TabStop = false;
            this.PacienteGroupBox.Text = "Datos del Paciente";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(21, 38);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(221, 20);
            this.NombreTextBox.TabIndex = 6;
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Location = new System.Drawing.Point(259, 38);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(199, 20);
            this.IdentidadTextBox.TabIndex = 7;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(474, 38);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(60, 20);
            this.EdadTextBox.TabIndex = 8;
            // 
            // DoctorGroupBox
            // 
            this.DoctorGroupBox.Controls.Add(this.EspecialidadTextBox1);
            this.DoctorGroupBox.Controls.Add(this.DocNombreTextBox);
            this.DoctorGroupBox.Controls.Add(this.label5);
            this.DoctorGroupBox.Controls.Add(this.label4);
            this.DoctorGroupBox.Location = new System.Drawing.Point(16, 106);
            this.DoctorGroupBox.Name = "DoctorGroupBox";
            this.DoctorGroupBox.Size = new System.Drawing.Size(598, 70);
            this.DoctorGroupBox.TabIndex = 6;
            this.DoctorGroupBox.TabStop = false;
            this.DoctorGroupBox.Text = "Datos del Doctor";
            // 
            // PreclinicaGroupBox
            // 
            this.PreclinicaGroupBox.Controls.Add(this.textBox6);
            this.PreclinicaGroupBox.Controls.Add(this.textBox5);
            this.PreclinicaGroupBox.Controls.Add(this.textBox4);
            this.PreclinicaGroupBox.Controls.Add(this.textBox3);
            this.PreclinicaGroupBox.Controls.Add(this.textBox2);
            this.PreclinicaGroupBox.Controls.Add(this.textBox1);
            this.PreclinicaGroupBox.Controls.Add(this.label11);
            this.PreclinicaGroupBox.Controls.Add(this.label10);
            this.PreclinicaGroupBox.Controls.Add(this.label9);
            this.PreclinicaGroupBox.Controls.Add(this.label8);
            this.PreclinicaGroupBox.Controls.Add(this.label7);
            this.PreclinicaGroupBox.Controls.Add(this.label6);
            this.PreclinicaGroupBox.Location = new System.Drawing.Point(16, 197);
            this.PreclinicaGroupBox.Name = "PreclinicaGroupBox";
            this.PreclinicaGroupBox.Size = new System.Drawing.Size(598, 151);
            this.PreclinicaGroupBox.TabIndex = 7;
            this.PreclinicaGroupBox.TabStop = false;
            this.PreclinicaGroupBox.Text = "Preclinica";
            // 
            // EspecialidadTextBox1
            // 
            this.EspecialidadTextBox1.Location = new System.Drawing.Point(259, 36);
            this.EspecialidadTextBox1.Name = "EspecialidadTextBox1";
            this.EspecialidadTextBox1.Size = new System.Drawing.Size(199, 20);
            this.EspecialidadTextBox1.TabIndex = 12;
            // 
            // DocNombreTextBox
            // 
            this.DocNombreTextBox.Location = new System.Drawing.Point(21, 36);
            this.DocNombreTextBox.Name = "DocNombreTextBox";
            this.DocNombreTextBox.Size = new System.Drawing.Size(221, 20);
            this.DocNombreTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Identidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Estatura cm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Peso Lbs.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Presion Sistolica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Presion Diastolica";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Pulsaciones por Minuto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Enfermedad base";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(313, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(84, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(420, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(114, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(21, 105);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(114, 20);
            this.textBox6.TabIndex = 11;
            // 
            // GuardarBbutton
            // 
            this.GuardarBbutton.Location = new System.Drawing.Point(16, 366);
            this.GuardarBbutton.Name = "GuardarBbutton";
            this.GuardarBbutton.Size = new System.Drawing.Size(81, 29);
            this.GuardarBbutton.TabIndex = 8;
            this.GuardarBbutton.Text = "Guardar";
            this.GuardarBbutton.UseVisualStyleBackColor = true;
            // 
            // RectaButton
            // 
            this.RectaButton.Location = new System.Drawing.Point(539, 366);
            this.RectaButton.Name = "RectaButton";
            this.RectaButton.Size = new System.Drawing.Size(81, 29);
            this.RectaButton.TabIndex = 9;
            this.RectaButton.Text = "Receta";
            this.RectaButton.UseVisualStyleBackColor = true;
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 416);
            this.Controls.Add(this.RectaButton);
            this.Controls.Add(this.GuardarBbutton);
            this.Controls.Add(this.PreclinicaGroupBox);
            this.Controls.Add(this.DoctorGroupBox);
            this.Controls.Add(this.PacienteGroupBox);
            this.Name = "FrmConsultas";
            this.Text = "Consultas";
            this.PacienteGroupBox.ResumeLayout(false);
            this.PacienteGroupBox.PerformLayout();
            this.DoctorGroupBox.ResumeLayout(false);
            this.DoctorGroupBox.PerformLayout();
            this.PreclinicaGroupBox.ResumeLayout(false);
            this.PreclinicaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox PacienteGroupBox;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.GroupBox DoctorGroupBox;
        private System.Windows.Forms.GroupBox PreclinicaGroupBox;
        private System.Windows.Forms.TextBox EspecialidadTextBox1;
        private System.Windows.Forms.TextBox DocNombreTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GuardarBbutton;
        private System.Windows.Forms.Button RectaButton;
    }
}