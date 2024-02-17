namespace Hilo.Pantallas
{
    partial class SJF
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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(62, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(548, 289);
            listBox1.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(62, 394);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 40);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 9;
            label1.Text = "BurstTime";
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(120, 32);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 8;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(201, 32);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtRafaga
            // 
            txtRafaga.Location = new Point(389, 32);
            txtRafaga.Name = "txtRafaga";
            txtRafaga.Size = new Size(100, 23);
            txtRafaga.TabIndex = 6;
            // 
            // SJF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(657, 450);
            Controls.Add(listBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Controls.Add(btnEjecutar);
            Controls.Add(btnAgregar);
            Controls.Add(txtRafaga);
            Name = "SJF";
            Text = "SJF";
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
    }
}