namespace proyecto1
{
    partial class FormTopico
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
            btnregresar = new Button();
            txtpresion = new TextBox();
            txttemp = new TextBox();
            txtobs = new TextBox();
            lblpresion = new Label();
            lbltemp = new Label();
            lblobs = new Label();
            dataGridView1 = new DataGridView();
            lbldni = new Label();
            txtdni = new TextBox();
            btnatencion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.FromArgb(230, 81, 0);
            btnregresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregresar.ForeColor = Color.White;
            btnregresar.Location = new Point(410, 345);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(147, 57);
            btnregresar.TabIndex = 2;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += button1_Click;
            // 
            // txtpresion
            // 
            txtpresion.Location = new Point(156, 81);
            txtpresion.Name = "txtpresion";
            txtpresion.Size = new Size(125, 27);
            txtpresion.TabIndex = 3;
            // 
            // txttemp
            // 
            txttemp.Location = new Point(156, 134);
            txttemp.Name = "txttemp";
            txttemp.Size = new Size(125, 27);
            txttemp.TabIndex = 4;
            // 
            // txtobs
            // 
            txtobs.Location = new Point(385, 73);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new Size(172, 84);
            txtobs.TabIndex = 5;
            // 
            // lblpresion
            // 
            lblpresion.AutoSize = true;
            lblpresion.Location = new Point(40, 84);
            lblpresion.Name = "lblpresion";
            lblpresion.Size = new Size(110, 20);
            lblpresion.TabIndex = 6;
            lblpresion.Text = "Presion Arterial";
            // 
            // lbltemp
            // 
            lbltemp.AutoSize = true;
            lbltemp.Location = new Point(12, 137);
            lbltemp.Name = "lbltemp";
            lbltemp.Size = new Size(138, 20);
            lbltemp.TabIndex = 7;
            lbltemp.Text = "Temperatura y Peso";
            // 
            // lblobs
            // 
            lblobs.AutoSize = true;
            lblobs.Location = new Point(385, 50);
            lblobs.Name = "lblobs";
            lblobs.Size = new Size(105, 20);
            lblobs.TabIndex = 8;
            lblobs.Text = "Observaciones";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 9;
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Location = new Point(46, 37);
            lbldni.Name = "lbldni";
            lbldni.Size = new Size(104, 20);
            lbldni.TabIndex = 10;
            lbldni.Text = "DNI / Paciente";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(156, 37);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 11;
            // 
            // btnatencion
            // 
            btnatencion.BackColor = Color.FromArgb(2, 136, 209);
            btnatencion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnatencion.ForeColor = Color.White;
            btnatencion.Location = new Point(410, 189);
            btnatencion.Name = "btnatencion";
            btnatencion.Size = new Size(152, 55);
            btnatencion.TabIndex = 12;
            btnatencion.Text = "Guardar Atencion";
            btnatencion.UseVisualStyleBackColor = false;
            // 
            // FormTopico
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 241);
            ClientSize = new Size(602, 450);
            Controls.Add(btnatencion);
            Controls.Add(txtdni);
            Controls.Add(lbldni);
            Controls.Add(dataGridView1);
            Controls.Add(lblobs);
            Controls.Add(lbltemp);
            Controls.Add(lblpresion);
            Controls.Add(txtobs);
            Controls.Add(txttemp);
            Controls.Add(txtpresion);
            Controls.Add(btnregresar);
            Name = "FormTopico";
            Text = "Módulo de Tópico / Enfermería";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnregresar;
        private TextBox txtpresion;
        private TextBox txttemp;
        private TextBox txtobs;
        private Label lblpresion;
        private Label lbltemp;
        private Label lblobs;
        private DataGridView dataGridView1;
        private Label lbldni;
        private TextBox txtdni;
        private Button btnatencion;
    }
}