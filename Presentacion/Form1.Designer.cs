namespace EjemploEscrito
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIDVenta = new System.Windows.Forms.TextBox();
            this.textBoxPrecioVen = new System.Windows.Forms.TextBox();
            this.textBoxIdProp = new System.Windows.Forms.TextBox();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.button14 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDProp1 = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxM2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewPropiedad = new System.Windows.Forms.DataGridView();
            this.button13 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPrecioProp = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedad)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.dataGridViewVenta);
            this.tabPage2.Controls.Add(this.textBoxIdProp);
            this.tabPage2.Controls.Add(this.textBoxPrecioVen);
            this.tabPage2.Controls.Add(this.textBoxIDVenta);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Precio:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID Propiedad:";
            // 
            // textBoxIDVenta
            // 
            this.textBoxIDVenta.Location = new System.Drawing.Point(70, 6);
            this.textBoxIDVenta.Name = "textBoxIDVenta";
            this.textBoxIDVenta.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDVenta.TabIndex = 12;
            // 
            // textBoxPrecioVen
            // 
            this.textBoxPrecioVen.Location = new System.Drawing.Point(70, 39);
            this.textBoxPrecioVen.Name = "textBoxPrecioVen";
            this.textBoxPrecioVen.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecioVen.TabIndex = 13;
            // 
            // textBoxIdProp
            // 
            this.textBoxIdProp.Location = new System.Drawing.Point(107, 76);
            this.textBoxIdProp.Name = "textBoxIdProp";
            this.textBoxIdProp.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdProp.TabIndex = 14;
            this.textBoxIdProp.TextChanged += new System.EventHandler(this.NOOO_TextChanged);
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Location = new System.Drawing.Point(264, 6);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.RowHeadersWidth = 51;
            this.dataGridViewVenta.RowTemplate.Height = 24;
            this.dataGridViewVenta.Size = new System.Drawing.Size(635, 443);
            this.dataGridViewVenta.TabIndex = 21;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button14.Location = new System.Drawing.Point(14, 124);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(161, 44);
            this.button14.TabIndex = 24;
            this.button14.Text = "Altas";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button8.Location = new System.Drawing.Point(14, 193);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(161, 44);
            this.button8.TabIndex = 25;
            this.button8.Text = "Bajas";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button7.Location = new System.Drawing.Point(14, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 44);
            this.button7.TabIndex = 26;
            this.button7.Text = "Consultas";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(14, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 44);
            this.button5.TabIndex = 28;
            this.button5.Text = "Listado";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxTipo);
            this.tabPage1.Controls.Add(this.textBoxPrecioProp);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.dataGridViewPropiedad);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBoxM2);
            this.tabPage1.Controls.Add(this.textBoxDireccion);
            this.tabPage1.Controls.Add(this.textBoxIDProp1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Propiedades";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "m^2:";
            // 
            // textBoxIDProp1
            // 
            this.textBoxIDProp1.Location = new System.Drawing.Point(76, 21);
            this.textBoxIDProp1.Name = "textBoxIDProp1";
            this.textBoxIDProp1.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDProp1.TabIndex = 4;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(76, 85);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 22);
            this.textBoxDireccion.TabIndex = 6;
            // 
            // textBoxM2
            // 
            this.textBoxM2.Location = new System.Drawing.Point(76, 121);
            this.textBoxM2.Name = "textBoxM2";
            this.textBoxM2.Size = new System.Drawing.Size(100, 22);
            this.textBoxM2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(15, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Altas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(15, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Bajas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(15, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "Consultas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(15, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 44);
            this.button4.TabIndex = 11;
            this.button4.Text = "Modificaciones";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewPropiedad
            // 
            this.dataGridViewPropiedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropiedad.Location = new System.Drawing.Point(264, 3);
            this.dataGridViewPropiedad.Name = "dataGridViewPropiedad";
            this.dataGridViewPropiedad.RowHeadersWidth = 51;
            this.dataGridViewPropiedad.RowTemplate.Height = 24;
            this.dataGridViewPropiedad.Size = new System.Drawing.Size(635, 443);
            this.dataGridViewPropiedad.TabIndex = 22;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button13.Location = new System.Drawing.Point(15, 402);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(161, 44);
            this.button13.TabIndex = 23;
            this.button13.Text = "Listado";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Location = new System.Drawing.Point(14, 390);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 44);
            this.button6.TabIndex = 29;
            this.button6.Text = "Imprimir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Precio:";
            // 
            // textBoxPrecioProp
            // 
            this.textBoxPrecioProp.Location = new System.Drawing.Point(76, 164);
            this.textBoxPrecioProp.Name = "textBoxPrecioProp";
            this.textBoxPrecioProp.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecioProp.TabIndex = 25;
            this.textBoxPrecioProp.TextChanged += new System.EventHandler(this.textBoxPrecioProp_TextChanged);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "casa",
            "apartamento",
            "terreno"});
            this.comboBoxTipo.Location = new System.Drawing.Point(72, 54);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(104, 24);
            this.comboBoxTipo.TabIndex = 26;
            this.comboBoxTipo.Text = "casa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 509);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedad)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.TextBox textBoxIdProp;
        private System.Windows.Forms.TextBox textBoxPrecioVen;
        private System.Windows.Forms.TextBox textBoxIDVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dataGridViewPropiedad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxM2;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxIDProp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBoxPrecioProp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTipo;
    }
}

