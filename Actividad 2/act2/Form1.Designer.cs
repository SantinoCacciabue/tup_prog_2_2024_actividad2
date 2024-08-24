namespace act2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bListarInc = new System.Windows.Forms.Button();
            this.bAsignarPolicia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBagentes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nHora = new System.Windows.Forms.NumericUpDown();
            this.nMinutos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinutos = new System.Windows.Forms.TextBox();
            this.bAsignarGuardia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNombrePers = new System.Windows.Forms.TextBox();
            this.tbDniPer = new System.Windows.Forms.TextBox();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.nHoraInc = new System.Windows.Forms.NumericUpDown();
            this.nMinutoInc = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cBguardias = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHoraInc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutoInc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bListarInc);
            this.groupBox1.Controls.Add(this.bAsignarPolicia);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administración comisaría";
            // 
            // bListarInc
            // 
            this.bListarInc.Location = new System.Drawing.Point(317, 31);
            this.bListarInc.Name = "bListarInc";
            this.bListarInc.Size = new System.Drawing.Size(89, 46);
            this.bListarInc.TabIndex = 1;
            this.bListarInc.Text = "Listar Incidentes";
            this.bListarInc.UseVisualStyleBackColor = true;
            this.bListarInc.Click += new System.EventHandler(this.bListarInc_Click);
            // 
            // bAsignarPolicia
            // 
            this.bAsignarPolicia.Location = new System.Drawing.Point(222, 31);
            this.bAsignarPolicia.Name = "bAsignarPolicia";
            this.bAsignarPolicia.Size = new System.Drawing.Size(89, 46);
            this.bAsignarPolicia.TabIndex = 0;
            this.bAsignarPolicia.Text = "Asignar policía";
            this.bAsignarPolicia.UseVisualStyleBackColor = true;
            this.bAsignarPolicia.Click += new System.EventHandler(this.bAsignarPolicia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAsignarGuardia);
            this.groupBox2.Controls.Add(this.tbMinutos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nMinutos);
            this.groupBox2.Controls.Add(this.nHora);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cBagentes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones sobre el agente";
            // 
            // cBagentes
            // 
            this.cBagentes.FormattingEnabled = true;
            this.cBagentes.Location = new System.Drawing.Point(132, 17);
            this.cBagentes.Name = "cBagentes";
            this.cBagentes.Size = new System.Drawing.Size(91, 21);
            this.cBagentes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa de agente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duración en minutos:";
            // 
            // nHora
            // 
            this.nHora.Location = new System.Drawing.Point(151, 49);
            this.nHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nHora.Name = "nHora";
            this.nHora.Size = new System.Drawing.Size(45, 20);
            this.nHora.TabIndex = 4;
            // 
            // nMinutos
            // 
            this.nMinutos.Location = new System.Drawing.Point(215, 49);
            this.nMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nMinutos.Name = "nMinutos";
            this.nMinutos.Size = new System.Drawing.Size(45, 20);
            this.nMinutos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // tbMinutos
            // 
            this.tbMinutos.Location = new System.Drawing.Point(155, 76);
            this.tbMinutos.Name = "tbMinutos";
            this.tbMinutos.Size = new System.Drawing.Size(100, 20);
            this.tbMinutos.TabIndex = 7;
            // 
            // bAsignarGuardia
            // 
            this.bAsignarGuardia.Location = new System.Drawing.Point(317, 41);
            this.bAsignarGuardia.Name = "bAsignarGuardia";
            this.bAsignarGuardia.Size = new System.Drawing.Size(89, 46);
            this.bAsignarGuardia.TabIndex = 2;
            this.bAsignarGuardia.Text = "Asignar guardia";
            this.bAsignarGuardia.UseVisualStyleBackColor = true;
            this.bAsignarGuardia.Click += new System.EventHandler(this.bAsignarGuardia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cBguardias);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.nMinutoInc);
            this.groupBox3.Controls.Add(this.nHoraInc);
            this.groupBox3.Controls.Add(this.tbMotivo);
            this.groupBox3.Controls.Add(this.tbDniPer);
            this.groupBox3.Controls.Add(this.tbNombrePers);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(30, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 204);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administración de incidentes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de incidente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Persona";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "DNI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Motivo";
            // 
            // tbNombrePers
            // 
            this.tbNombrePers.Location = new System.Drawing.Point(109, 89);
            this.tbNombrePers.Name = "tbNombrePers";
            this.tbNombrePers.Size = new System.Drawing.Size(97, 20);
            this.tbNombrePers.TabIndex = 8;
            // 
            // tbDniPer
            // 
            this.tbDniPer.Location = new System.Drawing.Point(244, 89);
            this.tbDniPer.Name = "tbDniPer";
            this.tbDniPer.Size = new System.Drawing.Size(80, 20);
            this.tbDniPer.TabIndex = 8;
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(107, 121);
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(217, 65);
            this.tbMotivo.TabIndex = 9;
            // 
            // nHoraInc
            // 
            this.nHoraInc.Location = new System.Drawing.Point(115, 52);
            this.nHoraInc.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nHoraInc.Name = "nHoraInc";
            this.nHoraInc.Size = new System.Drawing.Size(45, 20);
            this.nHoraInc.TabIndex = 8;
            // 
            // nMinutoInc
            // 
            this.nMinutoInc.Location = new System.Drawing.Point(178, 52);
            this.nMinutoInc.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nMinutoInc.Name = "nMinutoInc";
            this.nMinutoInc.Size = new System.Drawing.Size(45, 20);
            this.nMinutoInc.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arresto",
            "Denuncia"});
            this.comboBox1.Location = new System.Drawing.Point(115, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Guardia:";
            // 
            // cBguardias
            // 
            this.cBguardias.FormattingEnabled = true;
            this.cBguardias.Location = new System.Drawing.Point(294, 23);
            this.cBguardias.Name = "cBguardias";
            this.cBguardias.Size = new System.Drawing.Size(91, 21);
            this.cBguardias.TabIndex = 8;
            this.cBguardias.SelectedIndexChanged += new System.EventHandler(this.cBguardias_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registrar Incidente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHoraInc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutoInc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAsignarPolicia;
        private System.Windows.Forms.Button bListarInc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBagentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nMinutos;
        private System.Windows.Forms.NumericUpDown nHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMinutos;
        private System.Windows.Forms.Button bAsignarGuardia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nMinutoInc;
        private System.Windows.Forms.NumericUpDown nHoraInc;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.TextBox tbDniPer;
        private System.Windows.Forms.TextBox tbNombrePers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBguardias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
    }
}

