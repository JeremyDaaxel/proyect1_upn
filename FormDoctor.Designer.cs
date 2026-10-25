namespace proyecto1
{
    partial class FormDoctor
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
            btnbuscar = new System.Windows.Forms.Button();
            lblinfo = new System.Windows.Forms.Label();
            lblsintoma = new System.Windows.Forms.Label();
            txtsintomas = new System.Windows.Forms.TextBox();
            lbldiagnostico = new System.Windows.Forms.Label();
            txtdiagnostico = new System.Windows.Forms.TextBox();
            lblreceta = new System.Windows.Forms.Label();
            txtreceta = new System.Windows.Forms.TextBox();
            btndiagnostico = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnregresar
            // 
            btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)81)), ((int)((byte)0)));
            btnregresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnregresar.ForeColor = System.Drawing.Color.White;
            btnregresar.Location = new System.Drawing.Point(740, 155);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new System.Drawing.Size(140, 42);
            btnregresar.TabIndex = 6;
            btnregresar.Text = "Regresar al Login";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += button1_Click;
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbldni.Location = new System.Drawing.Point(25, 20);
            lbldni.Name = "lbldni";
            lbldni.Size = new System.Drawing.Size(127, 15);
            lbldni.TabIndex = 7;
            lbldni.Text = "DNI / Código Paciente:";
            // 
            // txtdni
            // 
            txtdni.Location = new System.Drawing.Point(160, 17);
            txtdni.MaxLength = 8;
            txtdni.Name = "txtdni";
            txtdni.Size = new System.Drawing.Size(140, 23);
            txtdni.TabIndex = 0;
            txtdni.KeyPress += txtdni_KeyPress;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnbuscar.ForeColor = System.Drawing.Color.White;
            btnbuscar.Location = new System.Drawing.Point(310, 15);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new System.Drawing.Size(95, 27);
            btnbuscar.TabIndex = 1;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // lblinfo
            // 
            lblinfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblinfo.ForeColor = System.Drawing.Color.DarkBlue;
            lblinfo.Location = new System.Drawing.Point(420, 15);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new System.Drawing.Size(460, 28);
            lblinfo.TabIndex = 8;
            lblinfo.Text = "Ingresa el DNI del paciente para consultar triaje y especialidad de cita.";
            // 
            // lblsintoma
            // 
            lblsintoma.AutoSize = true;
            lblsintoma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblsintoma.Location = new System.Drawing.Point(25, 55);
            lblsintoma.Name = "lblsintoma";
            lblsintoma.Size = new System.Drawing.Size(168, 15);
            lblsintoma.TabIndex = 9;
            lblsintoma.Text = "Síntomas / Motivo de Consulta";
            // 
            // txtsintomas
            // 
            txtsintomas.Location = new System.Drawing.Point(25, 75);
            txtsintomas.Multiline = true;
            txtsintomas.Name = "txtsintomas";
            txtsintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtsintomas.Size = new System.Drawing.Size(265, 70);
            txtsintomas.TabIndex = 2;
            // 
            // lbldiagnostico
            // 
            lbldiagnostico.AutoSize = true;
            lbldiagnostico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbldiagnostico.Location = new System.Drawing.Point(310, 55);
            lbldiagnostico.Name = "lbldiagnostico";
            lbldiagnostico.Size = new System.Drawing.Size(113, 15);
            lbldiagnostico.TabIndex = 10;
            lbldiagnostico.Text = "Diagnóstico Médico";
            // 
            // txtdiagnostico
            // 
            txtdiagnostico.Location = new System.Drawing.Point(310, 75);
            txtdiagnostico.Multiline = true;
            txtdiagnostico.Name = "txtdiagnostico";
            txtdiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtdiagnostico.Size = new System.Drawing.Size(280, 70);
            txtdiagnostico.TabIndex = 3;
            // 
            // lblreceta
            // 
            lblreceta.AutoSize = true;
            lblreceta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblreceta.Location = new System.Drawing.Point(610, 55);
            lblreceta.Name = "lblreceta";
            lblreceta.Size = new System.Drawing.Size(117, 15);
            lblreceta.TabIndex = 11;
            lblreceta.Text = "Receta / Tratamiento";
            // 
            // txtreceta
            // 
            txtreceta.Location = new System.Drawing.Point(610, 75);
            txtreceta.Multiline = true;
            txtreceta.Name = "txtreceta";
            txtreceta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtreceta.Size = new System.Drawing.Size(270, 70);
            txtreceta.TabIndex = 4;
            // 
            // btndiagnostico
            // 
            btndiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btndiagnostico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btndiagnostico.ForeColor = System.Drawing.Color.White;
            btndiagnostico.Location = new System.Drawing.Point(25, 155);
            btndiagnostico.Name = "btndiagnostico";
            btndiagnostico.Size = new System.Drawing.Size(200, 42);
            btndiagnostico.TabIndex = 5;
            btndiagnostico.Text = "Guardar Diagnóstico";
            btndiagnostico.UseVisualStyleBackColor = false;
            btndiagnostico.Click += btndiagnostico_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(25, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(855, 280);
            dataGridView1.TabIndex = 12;
            dataGridView1.Columns.Add("colDni", "DNI");
            dataGridView1.Columns.Add("colPaciente", "Paciente");
            dataGridView1.Columns.Add("colEspecialidad", "Especialidad");
            dataGridView1.Columns.Add("colPresion", "Presión Art.");
            dataGridView1.Columns.Add("colTemp", "Temperatura");
            dataGridView1.Columns.Add("colPeso", "Peso");
            dataGridView1.Columns.Add("colSintomas", "Síntomas");
            dataGridView1.Columns.Add("colDiagnostico", "Diagnóstico");
            dataGridView1.Columns.Add("colReceta", "Receta Médica");
            // 
            // FormDoctor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)242)), ((int)((byte)241)));
            ClientSize = new System.Drawing.Size(905, 510);
            Controls.Add(dataGridView1);
            Controls.Add(lblinfo);
            Controls.Add(btnbuscar);
            Controls.Add(btndiagnostico);
            Controls.Add(txtreceta);
            Controls.Add(txtdiagnostico);
            Controls.Add(txtsintomas);
            Controls.Add(txtdni);
            Controls.Add(lblreceta);
            Controls.Add(lbldiagnostico);
            Controls.Add(lblsintoma);
            Controls.Add(lbldni);
            Controls.Add(btnregresar);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Módulo Doctor / Diagnóstico";
            Load += FormDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnregresar;
        private Label lbldni;
        private TextBox txtdni;
        private Button btnbuscar;
        private Label lblinfo;
        private Label lblsintoma;
        private TextBox txtsintomas;
        private Label lbldiagnostico;
        private TextBox txtdiagnostico;
        private Label lblreceta;
        private TextBox txtreceta;
        private Button btndiagnostico;
        private DataGridView dataGridView1;
    }
}
