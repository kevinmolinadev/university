namespace Hilo.Pantallas
{
    partial class FCFS
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
            Salida = new Label();
            btnAgregar = new Button();
            InputBurts = new TextBox();
            label = new Label();
            btnEjecutar = new Button();
            label2 = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // Salida
            // 
            Salida.AutoSize = true;
            Salida.Location = new Point(19, 110);
            Salida.Name = "Salida";
            Salida.Size = new Size(0, 15);
            Salida.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(100, 43);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // InputBurts
            // 
            InputBurts.Location = new Point(269, 43);
            InputBurts.Name = "InputBurts";
            InputBurts.Size = new Size(61, 23);
            InputBurts.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(189, 46);
            label.Name = "label";
            label.Size = new Size(63, 15);
            label.TabIndex = 3;
            label.Text = "Burst Time";
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(19, 43);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 4;
            btnEjecutar.Text = "EJECUTAR";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 82);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(19, 403);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FCFS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Gold;
            ClientSize = new Size(557, 438);
            Controls.Add(btnLimpiar);
            Controls.Add(label2);
            Controls.Add(btnEjecutar);
            Controls.Add(label);
            Controls.Add(InputBurts);
            Controls.Add(btnAgregar);
            Controls.Add(Salida);
            Name = "FCFS";
            Text = "FCFS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Salida;
        private Button btnAgregar;
        private TextBox InputBurts;
        private Label label;
        private Button btnEjecutar;
        private Label label2;
        private Button btnLimpiar;
    }
}