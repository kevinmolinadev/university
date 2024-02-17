namespace Hilo.Pantallas
{
    partial class RoundRobin
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
            btnLimpiar = new Button();
            label2 = new Label();
            btnEjecutar = new Button();
            label = new Label();
            InputBurts = new TextBox();
            btnAgregar = new Button();
            Salida = new Label();
            label1 = new Label();
            InputQuantum = new TextBox();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(26, 388);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 13;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(26, 28);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 12;
            btnEjecutar.Text = "EJECUTAR";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(196, 31);
            label.Name = "label";
            label.Size = new Size(63, 15);
            label.TabIndex = 11;
            label.Text = "Burst Time";
            // 
            // InputBurts
            // 
            InputBurts.Location = new Point(276, 28);
            InputBurts.Name = "InputBurts";
            InputBurts.Size = new Size(61, 23);
            InputBurts.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(107, 28);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Salida
            // 
            Salida.AutoSize = true;
            Salida.Location = new Point(26, 95);
            Salida.Name = "Salida";
            Salida.Size = new Size(0, 15);
            Salida.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 16;
            label1.Text = "Quantum";
            // 
            // InputQuantum
            // 
            InputQuantum.Location = new Point(446, 29);
            InputQuantum.Name = "InputQuantum";
            InputQuantum.Size = new Size(61, 23);
            InputQuantum.TabIndex = 15;
            // 
            // RoundRobin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(572, 426);
            Controls.Add(label1);
            Controls.Add(InputQuantum);
            Controls.Add(btnLimpiar);
            Controls.Add(label2);
            Controls.Add(btnEjecutar);
            Controls.Add(label);
            Controls.Add(InputBurts);
            Controls.Add(btnAgregar);
            Controls.Add(Salida);
            Name = "RoundRobin";
            Text = "RoundRobin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Label label2;
        private Button btnEjecutar;
        private Label label;
        private TextBox InputBurts;
        private Button btnAgregar;
        private Label Salida;
        private Label label1;
        private TextBox InputQuantum;
    }
}