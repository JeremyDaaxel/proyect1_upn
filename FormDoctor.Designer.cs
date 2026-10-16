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
            lblsintoma = new System.Windows.Forms.Label();
            lbldiagnostico = new System.Windows.Forms.Label();
            lblreceta = new System.Windows.Forms.Label();
            txtdni = new System.Windows.Forms.TextBox();
            txtsintomas = new System.Windows.Forms.TextBox();
            txtdiagnostico = new System.Windows.Forms.TextBox();
            txtreceta = new System.Windows.Forms.TextBox();
            btndiagnostico = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnregresar
            // 
            btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)81)), ((int)((byte)0)));
            btnregresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnregresar.ForeColor = System.Drawing.Color.White;
            btnregresar.Location = new System.Drawing.Point(415, 344);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new System.Drawing.Size(147, 57);
            btnregresar.TabIndex = 2;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += button1_Click;
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Location = new System.Drawing.Point(40, 61);
            lbldni.Name = "lbldni";
            lbldni.Size = new System.Drawing.Size(125, 15);
            lbldni.TabIndex = 3;
            lbldni.Text = "DNI / Código Paciente";
            // 
            // lblsintoma
            // 
            lblsintoma.AutoSize = true;
            lblsintoma.Location = new System.Drawing.Point(40, 107);
            lblsintoma.Name = "lblsintoma";
            lblsintoma.Size = new System.Drawing.Size(171, 15);
            lblsintoma.TabIndex = 4;
            lblsintoma.Text = "Síntomas / Motivo de Consulta";
            // 
            // lbldiagnostico
            // 
            lbldiagnostico.AutoSize = true;
            lbldiagnostico.Location = new System.Drawing.Point(40, 175);
            lbldiagnostico.Name = "lbldiagnostico";
            lbldiagnostico.Size = new System.Drawing.Size(113, 15);
            lbldiagnostico.TabIndex = 5;
            lbldiagnostico.Text = "Diagnóstico Médico";
            // 
            // lblreceta
            // 
            lblreceta.AutoSize = true;
            lblreceta.Location = new System.Drawing.Point(40, 246);
            lblreceta.Name = "lblreceta";
            lblreceta.Size = new System.Drawing.Size(117, 15);
            lblreceta.TabIndex = 6;
            lblreceta.Text = "Receta / Tratamiento";
            // 
            // txtdni
            // 
            txtdni.Location = new System.Drawing.Point(203, 58);
            txtdni.Name = "txtdni";
            txtdni.Size = new System.Drawing.Size(181, 23);
            txtdni.TabIndex = 7;
            // 
            // txtsintomas
            // 
            txtsintomas.Location = new System.Drawing.Point(259, 102);
            txtsintomas.Multiline = true;
            txtsintomas.Name = "txtsintomas";
            txtsintomas.Size = new System.Drawing.Size(156, 46);
            txtsintomas.TabIndex = 8;
            // 
            // txtdiagnostico
            // 
            txtdiagnostico.Location = new System.Drawing.Point(184, 172);
            txtdiagnostico.Multiline = true;
            txtdiagnostico.Name = "txtdiagnostico";
            txtdiagnostico.Size = new System.Drawing.Size(195, 48);
            txtdiagnostico.TabIndex = 9;
            // 
            // txtreceta
            // 
            txtreceta.Location = new System.Drawing.Point(196, 240);
            txtreceta.Multiline = true;
            txtreceta.Name = "txtreceta";
            txtreceta.Size = new System.Drawing.Size(195, 48);
            txtreceta.TabIndex = 10;
            // 
            // btndiagnostico
            // 
            btndiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btndiagnostico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btndiagnostico.ForeColor = System.Drawing.Color.White;
            btndiagnostico.Location = new System.Drawing.Point(40, 344);
            btndiagnostico.Name = "btndiagnostico";
            btndiagnostico.Size = new System.Drawing.Size(167, 57);
            btndiagnostico.TabIndex = 11;
            btndiagnostico.Text = "Guardar Diagnostico";
            btndiagnostico.UseVisualStyleBackColor = false;
            // 
            // FormDoctor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)242)), ((int)((byte)241)));
            ClientSize = new System.Drawing.Size(602, 450);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnregresar;
        private Label lbldni;
        private Label lblsintoma;
        private Label lbldiagnostico;
        private Label lblreceta;
        private TextBox txtdni;
        private TextBox txtsintomas;
        private TextBox txtdiagnostico;
        private TextBox txtreceta;
        private Button btndiagnostico;
    }
}