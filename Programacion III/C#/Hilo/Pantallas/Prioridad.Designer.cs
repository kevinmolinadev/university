namespace Hilo.Pantallas
{
    partial class Prioridad
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
            label1 = new Label();
            InputPrioridad = new TextBox();
            btnLimpiar = new Button();
            label2 = new Label();
            btnEjecutar = new Button();
            label = new Label();
            InputBurts = new TextBox();
            btnAgregar = new Button();
            Salida = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 41);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 25;
            label1.Text = "Prioridad";
            // 
            // InputPrioridad
            // 
            InputPrioridad.Location = new Point(457, 38);
            InputPrioridad.Name = "InputPrioridad";
            InputPrioridad.Size = new Size(61, 23);
            InputPrioridad.TabIndex = 24;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(37, 397);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 22;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(37, 37);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 21;
            btnEjecutar.Text = "EJECUTAR";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(207, 40);
            label.Name = "label";
            label.Size = new Size(63, 15);
            label.TabIndex = 20;
            label.Text = "Burst Time";
            // 
            // InputBurts
            // 
            InputBurts.Location = new Point(287, 37);
            InputBurts.Name = "InputBurts";
            InputBurts.Size = new Size(61, 23);
            InputBurts.TabIndex = 19;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(118, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Salida
            // 
            Salida.AutoSize = true;
            Salida.Location = new Point(37, 104);
            Salida.Name = "Salida";
            Salida.Size = new Size(0, 15);
            Salida.TabIndex = 17;
            // 
            // Prioridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(581, 450);
            Controls.Add(label1);
            Controls.Add(InputPrioridad);
            Controls.Add(btnLimpiar);
            Controls.Add(label2);
            Controls.Add(btnEjecutar);
            Controls.Add(label);
            Controls.Add(InputBurts);
            Controls.Add(btnAgregar);
            Controls.Add(Salida);
            Name = "Prioridad";
            Text = "Prioridad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox InputPrioridad;
        private Button btnLimpiar;
        private Label label2;
        private Button btnEjecutar;
        private Label label;
        private TextBox InputBurts;
        private Button btnAgregar;
        private Label Salida;
    }
}