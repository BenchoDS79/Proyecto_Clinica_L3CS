namespace Proyecto_Clinica_L3CS
{
    partial class FrmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdentidadMaskedEditBox = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.BuscarClienteButton = new System.Windows.Forms.Button();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BuscarInsumoButton = new System.Windows.Forms.Button();
            this.InsumosTextBox = new System.Windows.Forms.TextBox();
            this.DetalleTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DetalleFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdentidadMaskedEditBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacturaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.IdentidadMaskedEditBox);
            this.groupBox1.Controls.Add(this.BuscarClienteButton);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente";
            // 
            // IdentidadMaskedEditBox
            // 
            this.IdentidadMaskedEditBox.BeforeTouchSize = new System.Drawing.Size(172, 20);
            this.IdentidadMaskedEditBox.Location = new System.Drawing.Point(12, 34);
            this.IdentidadMaskedEditBox.Mask = "####-####-#####";
            this.IdentidadMaskedEditBox.MaxLength = 15;
            this.IdentidadMaskedEditBox.Name = "IdentidadMaskedEditBox";
            this.IdentidadMaskedEditBox.Size = new System.Drawing.Size(172, 20);
            this.IdentidadMaskedEditBox.TabIndex = 6;
            this.IdentidadMaskedEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadMaskedEditBox_KeyPress);
            // 
            // BuscarClienteButton
            // 
            this.BuscarClienteButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarClienteButton.Image")));
            this.BuscarClienteButton.Location = new System.Drawing.Point(434, 29);
            this.BuscarClienteButton.Name = "BuscarClienteButton";
            this.BuscarClienteButton.Size = new System.Drawing.Size(42, 25);
            this.BuscarClienteButton.TabIndex = 5;
            this.BuscarClienteButton.UseVisualStyleBackColor = true;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(210, 34);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(215, 20);
            this.NombreTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.UsuarioTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.FechaDateTimePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 44);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(604, 15);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(136, 20);
            this.UsuarioTextBox.TabIndex = 6;
            this.UsuarioTextBox.TextChanged += new System.EventHandler(this.UsuarioTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Usuario";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(70, 15);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.FechaDateTimePicker.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BuscarInsumoButton);
            this.groupBox3.Controls.Add(this.InsumosTextBox);
            this.groupBox3.Controls.Add(this.DetalleTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insumos";
            // 
            // BuscarInsumoButton
            // 
            this.BuscarInsumoButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarInsumoButton.Image")));
            this.BuscarInsumoButton.Location = new System.Drawing.Point(436, 34);
            this.BuscarInsumoButton.Name = "BuscarInsumoButton";
            this.BuscarInsumoButton.Size = new System.Drawing.Size(40, 27);
            this.BuscarInsumoButton.TabIndex = 10;
            this.BuscarInsumoButton.UseVisualStyleBackColor = true;
            // 
            // InsumosTextBox
            // 
            this.InsumosTextBox.Location = new System.Drawing.Point(12, 41);
            this.InsumosTextBox.Name = "InsumosTextBox";
            this.InsumosTextBox.Size = new System.Drawing.Size(172, 20);
            this.InsumosTextBox.TabIndex = 9;
            // 
            // DetalleTextBox
            // 
            this.DetalleTextBox.Location = new System.Drawing.Point(210, 41);
            this.DetalleTextBox.Name = "DetalleTextBox";
            this.DetalleTextBox.Size = new System.Drawing.Size(215, 20);
            this.DetalleTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Detalle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Codigo Insumo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DetalleFacturaDataGridView
            // 
            this.DetalleFacturaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleFacturaDataGridView.Location = new System.Drawing.Point(0, 228);
            this.DetalleFacturaDataGridView.Name = "DetalleFacturaDataGridView";
            this.DetalleFacturaDataGridView.Size = new System.Drawing.Size(781, 156);
            this.DetalleFacturaDataGridView.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(573, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Descuento";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "ISV";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(561, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Total a Pagar";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtotalTextBox.Location = new System.Drawing.Point(652, 399);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubtotalTextBox.TabIndex = 9;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescuentoTextBox.Location = new System.Drawing.Point(652, 425);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescuentoTextBox.TabIndex = 10;
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ISVTextBox.Location = new System.Drawing.Point(652, 451);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.Size = new System.Drawing.Size(100, 20);
            this.ISVTextBox.TabIndex = 11;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalTextBox.Location = new System.Drawing.Point(652, 477);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 12;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 509);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.ISVTextBox);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetalleFacturaDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdentidadMaskedEditBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacturaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuscarClienteButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BuscarInsumoButton;
        private System.Windows.Forms.TextBox InsumosTextBox;
        private System.Windows.Forms.TextBox DetalleTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DetalleFacturaDataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox ISVTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox IdentidadMaskedEditBox;
    }
}