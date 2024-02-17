namespace PROGRAMA4
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDividir = new System.Windows.Forms.RadioButton();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbtSumar = new System.Windows.Forms.RadioButton();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OPERACIONES MATEMATICAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDividir);
            this.groupBox1.Controls.Add(this.txtValor3);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtMultiplicar);
            this.groupBox1.Controls.Add(this.rbtSumar);
            this.groupBox1.Controls.Add(this.txtValor2);
            this.groupBox1.Controls.Add(this.txtValor1);
            this.groupBox1.Location = new System.Drawing.Point(24, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 210);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // rbtDividir
            // 
            this.rbtDividir.AutoSize = true;
            this.rbtDividir.Location = new System.Drawing.Point(68, 152);
            this.rbtDividir.Name = "rbtDividir";
            this.rbtDividir.Size = new System.Drawing.Size(54, 17);
            this.rbtDividir.TabIndex = 19;
            this.rbtDividir.TabStop = true;
            this.rbtDividir.Text = "Dividir";
            this.rbtDividir.UseVisualStyleBackColor = true;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(67, 103);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(133, 20);
            this.txtValor3.TabIndex = 18;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(67, 175);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 23);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Numero";
            // 
            // rbtMultiplicar
            // 
            this.rbtMultiplicar.AutoSize = true;
            this.rbtMultiplicar.Location = new System.Drawing.Point(128, 129);
            this.rbtMultiplicar.Name = "rbtMultiplicar";
            this.rbtMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbtMultiplicar.TabIndex = 14;
            this.rbtMultiplicar.TabStop = true;
            this.rbtMultiplicar.Text = "Multiplicar";
            this.rbtMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbtSumar
            // 
            this.rbtSumar.AutoSize = true;
            this.rbtSumar.Location = new System.Drawing.Point(67, 129);
            this.rbtSumar.Name = "rbtSumar";
            this.rbtSumar.Size = new System.Drawing.Size(55, 17);
            this.rbtSumar.TabIndex = 13;
            this.rbtSumar.TabStop = true;
            this.rbtSumar.Text = "Sumar";
            this.rbtSumar.UseVisualStyleBackColor = true;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(67, 66);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(133, 20);
            this.txtValor2.TabIndex = 12;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(67, 28);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(133, 20);
            this.txtValor1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtDividir;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtMultiplicar;
        private System.Windows.Forms.RadioButton rbtSumar;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
    }
}

