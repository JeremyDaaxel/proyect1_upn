namespace proyecto1
{
    partial class FormRegistroPaciente
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
            btnsalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtdni = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtcel = new TextBox();
            cboseguro = new ComboBox();
            btnpaciente = new Button();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(230, 81, 0);
            btnsalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(418, 344);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(142, 55);
            btnsalir.TabIndex = 0;
            btnsalir.Text = "Regresar";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 38);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "DNI / Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 83);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 129);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 179);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 4;
            label4.Text = "Teléfono / Celular";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 224);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 5;
            label5.Text = "Tipo de Seguro";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(144, 35);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(205, 27);
            txtdni.TabIndex = 6;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(116, 80);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(233, 27);
            txtnombre.TabIndex = 7;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(118, 126);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(231, 27);
            txtapellido.TabIndex = 8;
            // 
            // txtcel
            // 
            txtcel.Location = new Point(173, 176);
            txtcel.Name = "txtcel";
            txtcel.Size = new Size(176, 27);
            txtcel.TabIndex = 9;
            // 
            // cboseguro
            // 
            cboseguro.FormattingEnabled = true;
            cboseguro.Items.AddRange(new object[] { "SIS", "Particular", "EsSalud" });
            cboseguro.Location = new Point(157, 221);
            cboseguro.Name = "cboseguro";
            cboseguro.Size = new Size(192, 28);
            cboseguro.TabIndex = 10;
            // 
            // btnpaciente
            // 
            btnpaciente.BackColor = Color.FromArgb(2, 136, 209);
            btnpaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpaciente.ForeColor = Color.White;
            btnpaciente.Location = new Point(68, 341);
            btnpaciente.Name = "btnpaciente";
            btnpaciente.Size = new Size(143, 58);
            btnpaciente.TabIndex = 11;
            btnpaciente.Text = "Guardar Paciente";
            btnpaciente.UseVisualStyleBackColor = false;
            // 
            // FormRegistroPaciente
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 241);
            ClientSize = new Size(602, 450);
            Controls.Add(btnpaciente);
            Controls.Add(cboseguro);
            Controls.Add(txtcel);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtdni);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsalir);
            Name = "FormRegistroPaciente";
            Text = "Registro de Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtdni;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtcel;
        private ComboBox cboseguro;
        private Button btnpaciente;
    }
}