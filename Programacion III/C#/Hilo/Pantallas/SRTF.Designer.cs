namespace Hilo.Pantallas
{
    partial class SRTF
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
            txtRafaga = new TextBox();
            btnAgregar = new Button();
            btnEjecutar = new Button();
            label1 = new Label();
            btnLimpiar = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtRafaga
            // 
            txtRafaga.Location = new Point(377, 41);
            txtRafaga.Name = "txtRafaga";
            txtRafaga.Size = new Size(100, 23);
            txtRafaga.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(189, 41);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(108, 41);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 49);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "BurstTime";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(33, 404);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(35, 93);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(555, 274);
            listBox1.TabIndex = 5;
            // 
            // SRTF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(624, 450);
            Controls.Add(listBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Controls.Add(btnEjecutar);
            Controls.Add(btnAgregar);
            Controls.Add(txtRafaga);
            Name = "SRTF";
            Text = "SRTF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRafaga;
        private Button btnAgregar;
        private Button btnEjecutar;
        private Label label1;
        private Button btnLimpiar;
        private ListBox listBox1;
    }
}