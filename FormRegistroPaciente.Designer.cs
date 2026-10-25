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
            btnsalir = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtdni = new System.Windows.Forms.TextBox();
            txtnombre = new System.Windows.Forms.TextBox();
            txtapellido = new System.Windows.Forms.TextBox();
            txtcel = new System.Windows.Forms.TextBox();
            cboseguro = new System.Windows.Forms.ComboBox();
            btnpaciente = new System.Windows.Forms.Button();
            lblcorreo = new System.Windows.Forms.Label();
            txtcorreo = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)81)), ((int)((byte)0)));
            btnsalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnsalir.ForeColor = System.Drawing.Color.White;
            btnsalir.Location = new System.Drawing.Point(418, 344);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new System.Drawing.Size(142, 55);
            btnsalir.TabIndex = 8;
            btnsalir.Text = "Regresar al Login";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 15);
            label1.TabIndex = 9;
            label1.Text = "DNI / Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 129);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 15);
            label3.TabIndex = 11;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(40, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 15);
            label4.TabIndex = 12;
            label4.Text = "Teléfono / Celular";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(40, 224);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 15);
            label5.TabIndex = 13;
            label5.Text = "Tipo de Seguro";
            // 
            // txtdni
            // 
            txtdni.Location = new System.Drawing.Point(144, 35);
            txtdni.MaxLength = 8;
            txtdni.Name = "txtdni";
            txtdni.Size = new System.Drawing.Size(205, 23);
            txtdni.TabIndex = 0;
            txtdni.KeyPress += txtNumeroSolo_KeyPress;
            // 
            // txtnombre
            // 
            txtnombre.Location = new System.Drawing.Point(144, 80);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new System.Drawing.Size(205, 23);
            txtnombre.TabIndex = 1;
            txtnombre.KeyPress += txtTextoSolo_KeyPress;
            // 
            // txtapellido
            // 
            txtapellido.Location = new System.Drawing.Point(144, 126);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new System.Drawing.Size(205, 23);
            txtapellido.TabIndex = 2;
            txtapellido.KeyPress += txtTextoSolo_KeyPress;
            // 
            // txtcel
            // 
            txtcel.Location = new System.Drawing.Point(144, 176);
            txtcel.MaxLength = 9;
            txtcel.Name = "txtcel";
            txtcel.Size = new System.Drawing.Size(205, 23);
            txtcel.TabIndex = 3;
            txtcel.KeyPress += txtNumeroSolo_KeyPress;
            // 
            // cboseguro
            // 
            cboseguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboseguro.FormattingEnabled = true;
            cboseguro.Items.AddRange(new object[] { "SIS", "Particular", "EsSalud" });
            cboseguro.Location = new System.Drawing.Point(144, 221);
            cboseguro.Name = "cboseguro";
            cboseguro.Size = new System.Drawing.Size(205, 23);
            cboseguro.TabIndex = 4;
            // 
            // btnpaciente
            // 
            btnpaciente.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btnpaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnpaciente.ForeColor = System.Drawing.Color.White;
            btnpaciente.Location = new System.Drawing.Point(68, 341);
            btnpaciente.Name = "btnpaciente";
            btnpaciente.Size = new System.Drawing.Size(143, 58);
            btnpaciente.TabIndex = 7;
            btnpaciente.Text = "Guardar Paciente";
            btnpaciente.UseVisualStyleBackColor = false;
            btnpaciente.Click += btnpaciente_Click;
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.Location = new System.Drawing.Point(40, 269);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new System.Drawing.Size(97, 15);
            lblcorreo.TabIndex = 14;
            lblcorreo.Text = "Correo Electrónico";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new System.Drawing.Point(144, 266);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new System.Drawing.Size(260, 23);
            txtcorreo.TabIndex = 5;
            // 
            // FormRegistroPaciente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)242)), ((int)((byte)241)));
            ClientSize = new System.Drawing.Size(602, 450);
            Controls.Add(txtcorreo);
            Controls.Add(lblcorreo);
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
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Label lblcorreo;
        private TextBox txtcorreo;
    }
}
