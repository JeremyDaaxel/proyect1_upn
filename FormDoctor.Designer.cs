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
            btnregresar = new Button();
            lbldni = new Label();
            lblsintoma = new Label();
            lbldiagnostico = new Label();
            lblreceta = new Label();
            txtdni = new TextBox();
            txtsintomas = new TextBox();
            txtdiagnostico = new TextBox();
            txtreceta = new TextBox();
            btndiagnostico = new Button();
            SuspendLayout();
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.FromArgb(230, 81, 0);
            btnregresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregresar.ForeColor = Color.White;
            btnregresar.Location = new Point(415, 344);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(147, 57);
            btnregresar.TabIndex = 2;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += button1_Click;
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Location = new Point(40, 61);
            lbldni.Name = "lbldni";
            lbldni.Size = new Size(157, 20);
            lbldni.TabIndex = 3;
            lbldni.Text = "DNI / Código Paciente";
            // 
            // lblsintoma
            // 
            lblsintoma.AutoSize = true;
            lblsintoma.Location = new Point(40, 107);
            lblsintoma.Name = "lblsintoma";
            lblsintoma.Size = new Size(213, 20);
            lblsintoma.TabIndex = 4;
            lblsintoma.Text = "Síntomas / Motivo de Consulta";
            // 
            // lbldiagnostico
            // 
            lbldiagnostico.AutoSize = true;
            lbldiagnostico.Location = new Point(40, 175);
            lbldiagnostico.Name = "lbldiagnostico";
            lbldiagnostico.Size = new Size(143, 20);
            lbldiagnostico.TabIndex = 5;
            lbldiagnostico.Text = "Diagnóstico Médico";
            // 
            // lblreceta
            // 
            lblreceta.AutoSize = true;
            lblreceta.Location = new Point(40, 246);
            lblreceta.Name = "lblreceta";
            lblreceta.Size = new Size(148, 20);
            lblreceta.TabIndex = 6;
            lblreceta.Text = "Receta / Tratamiento";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(203, 58);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(181, 27);
            txtdni.TabIndex = 7;
            // 
            // txtsintomas
            // 
            txtsintomas.Location = new Point(259, 102);
            txtsintomas.Multiline = true;
            txtsintomas.Name = "txtsintomas";
            txtsintomas.Size = new Size(156, 46);
            txtsintomas.TabIndex = 8;
            // 
            // txtdiagnostico
            // 
            txtdiagnostico.Location = new Point(184, 172);
            txtdiagnostico.Multiline = true;
            txtdiagnostico.Name = "txtdiagnostico";
            txtdiagnostico.Size = new Size(195, 48);
            txtdiagnostico.TabIndex = 9;
            // 
            // txtreceta
            // 
            txtreceta.Location = new Point(196, 240);
            txtreceta.Multiline = true;
            txtreceta.Name = "txtreceta";
            txtreceta.Size = new Size(195, 48);
            txtreceta.TabIndex = 10;
            // 
            // btndiagnostico
            // 
            btndiagnostico.BackColor = Color.FromArgb(2, 136, 209);
            btndiagnostico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndiagnostico.ForeColor = Color.White;
            btndiagnostico.Location = new Point(40, 344);
            btndiagnostico.Name = "btndiagnostico";
            btndiagnostico.Size = new Size(167, 57);
            btndiagnostico.TabIndex = 11;
            btndiagnostico.Text = "Guardar Diagnostico";
            btndiagnostico.UseVisualStyleBackColor = false;
            // 
            // FormDoctor
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 241);
            ClientSize = new Size(602, 450);
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
            Name = "FormDoctor";
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