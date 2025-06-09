namespace operaciones
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtIngresarUno = new System.Windows.Forms.TextBox();
            this.txtIngresarDos = new System.Windows.Forms.TextBox();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnResta);
            this.gbDatos.Controls.Add(this.btnDividir);
            this.gbDatos.Controls.Add(this.btnMultiplicar);
            this.gbDatos.Controls.Add(this.btnSuma);
            this.gbDatos.Controls.Add(this.lblResultado);
            this.gbDatos.Controls.Add(this.txtIngresarDos);
            this.gbDatos.Controls.Add(this.lblNumero2);
            this.gbDatos.Controls.Add(this.txtIngresarUno);
            this.gbDatos.Controls.Add(this.lblNumero1);
            this.gbDatos.Location = new System.Drawing.Point(71, 54);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(631, 276);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "datos";
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumero1.Location = new System.Drawing.Point(18, 62);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(90, 17);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Numero uno:";
            this.lblNumero1.Click += new System.EventHandler(this.lblNumero1_Click);
            // 
            // txtIngresarUno
            // 
            this.txtIngresarUno.Location = new System.Drawing.Point(21, 97);
            this.txtIngresarUno.Name = "txtIngresarUno";
            this.txtIngresarUno.Size = new System.Drawing.Size(100, 20);
            this.txtIngresarUno.TabIndex = 1;
            this.txtIngresarUno.TextChanged += new System.EventHandler(this.txtIngresarUno_TextChanged);
            // 
            // txtIngresarDos
            // 
            this.txtIngresarDos.Location = new System.Drawing.Point(21, 182);
            this.txtIngresarDos.Name = "txtIngresarDos";
            this.txtIngresarDos.Size = new System.Drawing.Size(100, 20);
            this.txtIngresarDos.TabIndex = 3;
            this.txtIngresarDos.TextChanged += new System.EventHandler(this.txtIngresarDos_TextChanged);
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumero2.Location = new System.Drawing.Point(18, 147);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(93, 17);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Numero dos :";
            this.lblNumero2.Click += new System.EventHandler(this.lblNumero2_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultado.Location = new System.Drawing.Point(181, 136);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 17);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(506, 173);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(99, 61);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(367, 173);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(99, 61);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(506, 56);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(99, 61);
            this.btnResta.TabIndex = 8;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Image = global::operaciones.Properties.Resources.mas;
            this.btnSuma.Location = new System.Drawing.Point(367, 56);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(99, 70);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtIngresarDos;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtIngresarUno;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblResultado;
    }
}

