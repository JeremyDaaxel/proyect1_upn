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
            lbldni = new System.Windows.Forms.Label();
            txtdni = new System.Windows.Forms.TextBox();
            lblpresion = new System.Windows.Forms.Label();
            txtpresion = new System.Windows.Forms.TextBox();
            lbltemp = new System.Windows.Forms.Label();
            txttemp = new System.Windows.Forms.TextBox();
            lblpeso = new System.Windows.Forms.Label();
            txtpeso = new System.Windows.Forms.TextBox();
            lblobs = new System.Windows.Forms.Label();
            txtobs = new System.Windows.Forms.TextBox();
            btnatencion = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnregresar
            // 
            btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)81)), ((int)((byte)0)));
            btnregresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnregresar.ForeColor = System.Drawing.Color.White;
            btnregresar.Location = new System.Drawing.Point(542, 175);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new System.Drawing.Size(140, 48);
            btnregresar.TabIndex = 6;
            btnregresar.Text = "Regresar al Login";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += button1_Click;
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbldni.Location = new System.Drawing.Point(25, 25);
            lbldni.Name = "lbldni";
            lbldni.Size = new System.Drawing.Size(83, 15);
            lbldni.TabIndex = 10;
            lbldni.Text = "DNI / Paciente";
            // 
            // txtdni
            // 
            txtdni.Location = new System.Drawing.Point(145, 22);
            txtdni.MaxLength = 8;
            txtdni.Name = "txtdni";
            txtdni.Size = new System.Drawing.Size(150, 23);
            txtdni.TabIndex = 0;
            txtdni.KeyPress += txtdni_KeyPress;
            // 
            // lblpresion
            // 
            lblpresion.AutoSize = true;
            lblpresion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblpresion.Location = new System.Drawing.Point(25, 65);
            lblpresion.Name = "lblpresion";
            lblpresion.Size = new System.Drawing.Size(87, 15);
            lblpresion.TabIndex = 6;
            lblpresion.Text = "Presión Arterial";
            // 
            // txtpresion
            // 
            txtpresion.Location = new System.Drawing.Point(145, 62);
            txtpresion.Name = "txtpresion";
            txtpresion.PlaceholderText = "ej. 120/80";
            txtpresion.Size = new System.Drawing.Size(150, 23);
            txtpresion.TabIndex = 1;
            // 
            // lbltemp
            // 
            lbltemp.AutoSize = true;
            lbltemp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbltemp.Location = new System.Drawing.Point(25, 105);
            lbltemp.Name = "lbltemp";
            lbltemp.Size = new System.Drawing.Size(99, 15);
            lbltemp.TabIndex = 7;
            lbltemp.Text = "Temperatura (°C)";
            // 
            // txttemp
            // 
            txttemp.Location = new System.Drawing.Point(145, 102);
            txttemp.Name = "txttemp";
            txttemp.PlaceholderText = "ej. 36.5";
            txttemp.Size = new System.Drawing.Size(150, 23);
            txttemp.TabIndex = 2;
            txttemp.KeyPress += txtDecimal_KeyPress;
            // 
            // lblpeso
            // 
            lblpeso.AutoSize = true;
            lblpeso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblpeso.Location = new System.Drawing.Point(25, 145);
            lblpeso.Name = "lblpeso";
            lblpeso.Size = new System.Drawing.Size(58, 15);
            lblpeso.TabIndex = 13;
            lblpeso.Text = "Peso (kg)";
            // 
            // txtpeso
            // 
            txtpeso.Location = new System.Drawing.Point(145, 142);
            txtpeso.Name = "txtpeso";
            txtpeso.PlaceholderText = "ej. 70.0";
            txtpeso.Size = new System.Drawing.Size(150, 23);
            txtpeso.TabIndex = 3;
            txtpeso.KeyPress += txtDecimal_KeyPress;
            // 
            // lblobs
            // 
            lblobs.AutoSize = true;
            lblobs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblobs.Location = new System.Drawing.Point(340, 22);
            lblobs.Name = "lblobs";
            lblobs.Size = new System.Drawing.Size(84, 15);
            lblobs.TabIndex = 8;
            lblobs.Text = "Observaciones";
            // 
            // txtobs
            // 
            txtobs.Location = new System.Drawing.Point(340, 43);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new System.Drawing.Size(342, 120);
            txtobs.TabIndex = 4;
            // 
            // btnatencion
            // 
            btnatencion.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btnatencion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnatencion.ForeColor = System.Drawing.Color.White;
            btnatencion.Location = new System.Drawing.Point(380, 175);
            btnatencion.Name = "btnatencion";
            btnatencion.Size = new System.Drawing.Size(150, 48);
            btnatencion.TabIndex = 5;
            btnatencion.Text = "Guardar Atención";
            btnatencion.UseVisualStyleBackColor = false;
            btnatencion.Click += btnatencion_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(25, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(657, 200);
            dataGridView1.TabIndex = 9;
            dataGridView1.Columns.Add("colDni", "DNI");
            dataGridView1.Columns.Add("colPresion", "Presión");
            dataGridView1.Columns.Add("colTemp", "Temperatura");
            dataGridView1.Columns.Add("colPeso", "Peso");
            dataGridView1.Columns.Add("colObs", "Observaciones");
            dataGridView1.Columns.Add("colSeguro", "Seguro");
            dataGridView1.Columns.Add("colPrecio", "Precio / Costo");
            // 
            // FormTopico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)242)), ((int)((byte)241)));
            ClientSize = new System.Drawing.Size(710, 460);
            Controls.Add(txtpeso);
            Controls.Add(lblpeso);
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
            Load += FormTopico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnregresar;
        private TextBox txtpresion;
        private TextBox txttemp;
        private Label lblpeso;
        private TextBox txtpeso;
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
