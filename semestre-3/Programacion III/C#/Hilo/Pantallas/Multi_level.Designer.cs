namespace Hilo.Pantallas
{
    partial class Multi_level
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
            listBox1 = new ListBox();
            btnLimpiar = new Button();
            label1 = new Label();
            btnEjecutar = new Button();
            btnAgregar = new Button();
            txtRafaga = new TextBox();
            label2 = new Label();
            txtNivel = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(47, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(540, 259);
            listBox1.TabIndex = 17;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(47, 398);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 15;
            label1.Text = "BurstTime";
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(118, 50);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 14;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(199, 50);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtRafaga
            // 
            txtRafaga.Location = new Point(387, 22);
            txtRafaga.Name = "txtRafaga";
            txtRafaga.Size = new Size(100, 23);
            txtRafaga.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 68);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 19;
            label2.Text = "Nivel";
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(387, 60);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(100, 23);
            txtNivel.TabIndex = 18;
            // 
            // Multi_level
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(628, 450);
            Controls.Add(label2);
            Controls.Add(txtNivel);
            Controls.Add(listBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Controls.Add(btnEjecutar);
            Controls.Add(btnAgregar);
            Controls.Add(txtRafaga);
            Name = "Multi_level";
            Text = "Multi_level";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnLimpiar;
        private Label label1;
        private Button btnEjecutar;
        private Button btnAgregar;
        private TextBox txtRafaga;
        private Label label2;
        private TextBox txtNivel;
    }
}