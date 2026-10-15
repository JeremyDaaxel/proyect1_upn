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
            lbldni = new Label();
            btnregresar = new Button();
            txtdni = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Font = new Font("Microsoft Sans Serif", 9F);
            lbldni.ForeColor = Color.Black;
            lbldni.Location = new Point(36, 46);
            lbldni.Name = "lbldni";
            lbldni.Size = new Size(117, 18);
            lbldni.TabIndex = 0;
            lbldni.Text = "DNI del Paciente";
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.FromArgb(230, 81, 0);
            btnregresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregresar.ForeColor = Color.White;
            btnregresar.Location = new Point(514, 361);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(165, 57);
            btnregresar.TabIndex = 1;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += button1_Click;
            // 
            // txtdni
            // 
            txtdni.Font = new Font("Microsoft Sans Serif", 9F);
            txtdni.Location = new Point(150, 43);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(302, 24);
            txtdni.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 26);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(57, 110);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 4;
            label1.Text = "Especialidad";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9F);
            dateTimePicker1.Location = new Point(150, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 24);
            dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(95, 169);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(430, 185);
            dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 136, 209);
            button1.Location = new Point(506, 110);
            button1.Name = "button1";
            button1.Size = new Size(173, 59);
            button1.TabIndex = 8;
            button1.Text = "Reservar Cita";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormCitas
            //
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 241);
            ClientSize = new Size(729, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtdni);
            Controls.Add(btnregresar);
            Controls.Add(lbldni);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "FormCitas";
            Text = "Modulo de Citas";
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