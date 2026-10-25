namespace proyecto1
{
    partial class FormCitas
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
            lbldni = new System.Windows.Forms.Label();
            btnregresar = new System.Windows.Forms.Button();
            txtdni = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lbldni.ForeColor = System.Drawing.Color.Black;
            lbldni.Location = new System.Drawing.Point(36, 46);
            lbldni.Name = "lbldni";
            lbldni.Size = new System.Drawing.Size(99, 15);
            lbldni.TabIndex = 0;
            lbldni.Text = "DNI del Paciente";
            // 
            // btnregresar
            // 
            btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)81)), ((int)((byte)0)));
            btnregresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnregresar.ForeColor = System.Drawing.Color.White;
            btnregresar.Location = new System.Drawing.Point(514, 361);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new System.Drawing.Size(165, 57);
            btnregresar.TabIndex = 1;
            btnregresar.Text = "Regresar al Login";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += button1_Click;
            // 
            // txtdni
            // 
            txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            txtdni.Location = new System.Drawing.Point(150, 43);
            txtdni.MaxLength = 8;
            txtdni.Name = "txtdni";
            txtdni.Size = new System.Drawing.Size(302, 21);
            txtdni.TabIndex = 2;
            txtdni.KeyPress += txtdni_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
            "Medicina General",
            "Pediatría",
            "Cardiología",
            "Ginecología",
            "Odontología",
            "Dermatología"});
            comboBox1.Location = new System.Drawing.Point(150, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(196, 23);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(57, 110);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 15);
            label1.TabIndex = 4;
            label1.Text = "Especialidad";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dateTimePicker1.Location = new System.Drawing.Point(150, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(226, 21);
            dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(95, 169);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(22, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(430, 185);
            dataGridView1.TabIndex = 7;
            dataGridView1.Columns.Add("colDni", "DNI");
            dataGridView1.Columns.Add("colEspecialidad", "Especialidad");
            dataGridView1.Columns.Add("colFecha", "Fecha");
            dataGridView1.Columns.Add("colCosto", "Costo (S/)");
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            button1.Location = new System.Drawing.Point(506, 110);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(173, 59);
            button1.TabIndex = 8;
            button1.Text = "Reservar Cita";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnreservar_Click;
            // 
            // FormCitas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)242)), ((int)((byte)241)));
            ClientSize = new System.Drawing.Size(729, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtdni);
            Controls.Add(btnregresar);
            Controls.Add(lbldni);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            ForeColor = System.Drawing.Color.White;
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Modulo de Citas";
            Load += FormCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldni;
        private Button btnregresar;
        private TextBox txtdni;
        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
