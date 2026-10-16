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
            btnregresar = new System.Windows.Forms.Button();
            txtpresion = new System.Windows.Forms.TextBox();
            txttemp = new System.Windows.Forms.TextBox();
            txtobs = new System.Windows.Forms.TextBox();
            lblpresion = new System.Windows.Forms.Label();
            lbltemp = new System.Windows.Forms.Label();
            lblobs = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            lbldni = new System.Windows.Forms.Label();
            txtdni = new System.Windows.Forms.TextBox();
            btnatencion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnregresar
            // 
            btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)81)), ((int)((byte)0)));
            btnregresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnregresar.ForeColor = System.Drawing.Color.White;
            btnregresar.Location = new System.Drawing.Point(410, 345);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new System.Drawing.Size(147, 57);
            btnregresar.TabIndex = 2;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += button1_Click;
            // 
            // txtpresion
            // 
            txtpresion.Location = new System.Drawing.Point(156, 81);
            txtpresion.Name = "txtpresion";
            txtpresion.Size = new System.Drawing.Size(125, 23);
            txtpresion.TabIndex = 3;
            // 
            // txttemp
            // 
            txttemp.Location = new System.Drawing.Point(156, 134);
            txttemp.Name = "txttemp";
            txttemp.Size = new System.Drawing.Size(125, 23);
            txttemp.TabIndex = 4;
            // 
            // txtobs
            // 
            txtobs.Location = new System.Drawing.Point(385, 73);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new System.Drawing.Size(172, 84);
            txtobs.TabIndex = 5;
            // 
            // lblpresion
            // 
            lblpresion.AutoSize = true;
            lblpresion.Location = new System.Drawing.Point(40, 84);
            lblpresion.Name = "lblpresion";
            lblpresion.Size = new System.Drawing.Size(87, 15);
            lblpresion.TabIndex = 6;
            lblpresion.Text = "Presion Arterial";
            // 
            // lbltemp
            // 
            lbltemp.AutoSize = true;
            lbltemp.Location = new System.Drawing.Point(12, 137);
            lbltemp.Name = "lbltemp";
            lbltemp.Size = new System.Drawing.Size(111, 15);
            lbltemp.TabIndex = 7;
            lbltemp.Text = "Temperatura y Peso";
            // 
            // lblobs
            // 
            lblobs.AutoSize = true;
            lblobs.Location = new System.Drawing.Point(385, 50);
            lblobs.Name = "lblobs";
            lblobs.Size = new System.Drawing.Size(84, 15);
            lblobs.TabIndex = 8;
            lblobs.Text = "Observaciones";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(36, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(300, 188);
            dataGridView1.TabIndex = 9;
            dataGridView1.Columns.Add("colDni", "DNI");
            dataGridView1.Columns.Add("colPresion", "Presión");
            dataGridView1.Columns.Add("colTempPeso", "Temp. y Peso");
            dataGridView1.Columns.Add("colObs", "Observaciones");
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Location = new System.Drawing.Point(46, 37);
            lbldni.Name = "lbldni";
            lbldni.Size = new System.Drawing.Size(83, 15);
            lbldni.TabIndex = 10;
            lbldni.Text = "DNI / Paciente";
            // 
            // txtdni
            // 
            txtdni.Location = new System.Drawing.Point(156, 37);
            txtdni.Name = "txtdni";
            txtdni.Size = new System.Drawing.Size(125, 23);
            txtdni.TabIndex = 11;
            // 
            // btnatencion
            // 
            btnatencion.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btnatencion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnatencion.ForeColor = System.Drawing.Color.White;
            btnatencion.Location = new System.Drawing.Point(410, 189);
            btnatencion.Name = "btnatencion";
            btnatencion.Size = new System.Drawing.Size(152, 55);
            btnatencion.TabIndex = 12;
            btnatencion.Text = "Guardar Atencion";
            btnatencion.UseVisualStyleBackColor = false;
            btnatencion.Click += btnatencion_Click;
            // 
            // FormTopico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)242)), ((int)((byte)241)));
            ClientSize = new System.Drawing.Size(602, 450);
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
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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