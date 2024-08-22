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
            this.bAsignarPolicia = new System.Windows.Forms.Button();
            this.bListarInc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBagentes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bListarInc);
            this.groupBox1.Controls.Add(this.bAsignarPolicia);
            this.groupBox1.Location = new System.Drawing.Point(30, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administración comisaría";
            // 
            // bAsignarPolicia
            // 
            this.bAsignarPolicia.Location = new System.Drawing.Point(387, 34);
            this.bAsignarPolicia.Name = "bAsignarPolicia";
            this.bAsignarPolicia.Size = new System.Drawing.Size(89, 46);
            this.bAsignarPolicia.TabIndex = 0;
            this.bAsignarPolicia.Text = "Asignar policía";
            this.bAsignarPolicia.UseVisualStyleBackColor = true;
            this.bAsignarPolicia.Click += new System.EventHandler(this.bAsignarPolicia_Click);
            // 
            // bListarInc
            // 
            this.bListarInc.Location = new System.Drawing.Point(482, 34);
            this.bListarInc.Name = "bListarInc";
            this.bListarInc.Size = new System.Drawing.Size(89, 46);
            this.bListarInc.TabIndex = 1;
            this.bListarInc.Text = "Listar Incidentes";
            this.bListarInc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBagentes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones sobre el agente";
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
            // cBagentes
            // 
            this.cBagentes.FormattingEnabled = true;
            this.cBagentes.Location = new System.Drawing.Point(132, 17);
            this.cBagentes.Name = "cBagentes";
            this.cBagentes.Size = new System.Drawing.Size(91, 21);
            this.cBagentes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAsignarPolicia;
        private System.Windows.Forms.Button bListarInc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBagentes;
        private System.Windows.Forms.Label label1;
    }
}

