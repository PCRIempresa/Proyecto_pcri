namespace Calculadora
{
    partial class Calculadora
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.cboResultados = new System.Windows.Forms.ComboBox();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.chkResultados = new System.Windows.Forms.CheckBox();
            this.chkFondo = new System.Windows.Forms.CheckBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbCientifica = new System.Windows.Forms.RadioButton();
            this.rbEstandar = new System.Windows.Forms.RadioButton();
            this.gbCientificas = new System.Windows.Forms.GroupBox();
            this.btnLogaritmo = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            this.gbCientificas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(12, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(274, 45);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(12, 63);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(274, 45);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 111);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(274, 45);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(292, 12);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(64, 45);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(292, 64);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(64, 45);
            this.btnMultiplicacion.TabIndex = 4;
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(362, 12);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(64, 45);
            this.btnResta.TabIndex = 5;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(362, 64);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(64, 45);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // cboResultados
            // 
            this.cboResultados.FormattingEnabled = true;
            this.cboResultados.Location = new System.Drawing.Point(138, 218);
            this.cboResultados.Name = "cboResultados";
            this.cboResultados.Size = new System.Drawing.Size(121, 21);
            this.cboResultados.TabIndex = 7;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(12, 218);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(120, 95);
            this.lstResultados.TabIndex = 8;
            // 
            // chkResultados
            // 
            this.chkResultados.AutoSize = true;
            this.chkResultados.Location = new System.Drawing.Point(138, 245);
            this.chkResultados.Name = "chkResultados";
            this.chkResultados.Size = new System.Drawing.Size(120, 17);
            this.chkResultados.TabIndex = 9;
            this.chkResultados.Text = "Muestro Resultados";
            this.chkResultados.UseVisualStyleBackColor = true;
            this.chkResultados.CheckedChanged += new System.EventHandler(this.chkResultados_CheckedChanged);
            // 
            // chkFondo
            // 
            this.chkFondo.AutoSize = true;
            this.chkFondo.Location = new System.Drawing.Point(138, 268);
            this.chkFondo.Name = "chkFondo";
            this.chkFondo.Size = new System.Drawing.Size(95, 17);
            this.chkFondo.TabIndex = 10;
            this.chkFondo.Text = "Fondo Amarillo";
            this.chkFondo.UseVisualStyleBackColor = true;
            this.chkFondo.CheckedChanged += new System.EventHandler(this.chkFondo_CheckedChanged);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbCientifica);
            this.gbTipo.Controls.Add(this.rbEstandar);
            this.gbTipo.Location = new System.Drawing.Point(432, 12);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(200, 100);
            this.gbTipo.TabIndex = 11;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // rbCientifica
            // 
            this.rbCientifica.AutoSize = true;
            this.rbCientifica.Location = new System.Drawing.Point(6, 42);
            this.rbCientifica.Name = "rbCientifica";
            this.rbCientifica.Size = new System.Drawing.Size(70, 17);
            this.rbCientifica.TabIndex = 1;
            this.rbCientifica.TabStop = true;
            this.rbCientifica.Text = "Científica";
            this.rbCientifica.UseVisualStyleBackColor = true;
            // 
            // rbEstandar
            // 
            this.rbEstandar.AutoSize = true;
            this.rbEstandar.Location = new System.Drawing.Point(6, 19);
            this.rbEstandar.Name = "rbEstandar";
            this.rbEstandar.Size = new System.Drawing.Size(67, 17);
            this.rbEstandar.TabIndex = 0;
            this.rbEstandar.TabStop = true;
            this.rbEstandar.Text = "Estandar";
            this.rbEstandar.UseVisualStyleBackColor = true;
            this.rbEstandar.CheckedChanged += new System.EventHandler(this.rbEstandar_CheckedChanged);
            // 
            // gbCientificas
            // 
            this.gbCientificas.Controls.Add(this.btnLogaritmo);
            this.gbCientificas.Controls.Add(this.btnPotencia);
            this.gbCientificas.Controls.Add(this.btnRaiz);
            this.gbCientificas.Location = new System.Drawing.Point(432, 118);
            this.gbCientificas.Name = "gbCientificas";
            this.gbCientificas.Size = new System.Drawing.Size(200, 110);
            this.gbCientificas.TabIndex = 12;
            this.gbCientificas.TabStop = false;
            this.gbCientificas.Text = "Científicas";
            // 
            // btnLogaritmo
            // 
            this.btnLogaritmo.Location = new System.Drawing.Point(6, 77);
            this.btnLogaritmo.Name = "btnLogaritmo";
            this.btnLogaritmo.Size = new System.Drawing.Size(75, 23);
            this.btnLogaritmo.TabIndex = 2;
            this.btnLogaritmo.Text = "Logaritmo";
            this.btnLogaritmo.UseVisualStyleBackColor = true;
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(6, 48);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 23);
            this.btnPotencia.TabIndex = 1;
            this.btnPotencia.Text = "Potencia";
            this.btnPotencia.UseVisualStyleBackColor = true;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(6, 19);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(75, 23);
            this.btnRaiz.TabIndex = 0;
            this.btnRaiz.Text = "Raíz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCientificas);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.chkFondo);
            this.Controls.Add(this.chkResultados);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.cboResultados);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.gbCientificas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.ComboBox cboResultados;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.CheckBox chkResultados;
        private System.Windows.Forms.CheckBox chkFondo;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbCientifica;
        private System.Windows.Forms.RadioButton rbEstandar;
        private System.Windows.Forms.GroupBox gbCientificas;
        private System.Windows.Forms.Button btnLogaritmo;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnRaiz;
    }
}

