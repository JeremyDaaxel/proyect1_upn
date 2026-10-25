namespace proyecto1
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lbltitulo = new Label();
            lblusuario = new Label();
            label3 = new Label();
            txtusuario = new TextBox();
            lblpassword = new Label();
            txtpassword = new TextBox();
            btningresar = new Button();
            btnRegistrar = new Button();
            lblSalir = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = SystemColors.ButtonFace;
            lbltitulo.Location = new Point(500, 60);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(187, 37);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "Iniciar Sesión";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusuario.ForeColor = SystemColors.ButtonHighlight;
            lblusuario.Location = new Point(465, 125);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(143, 17);
            lblusuario.TabIndex = 5;
            lblusuario.Text = "Usuario (DNI / Código)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(465, 430);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(465, 148);
            txtusuario.Margin = new Padding(3, 2, 3, 2);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "doctor / topico / DNI";
            txtusuario.Size = new Size(248, 23);
            txtusuario.TabIndex = 0;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpassword.ForeColor = SystemColors.ButtonHighlight;
            lblpassword.Location = new Point(465, 190);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(74, 17);
            lblpassword.TabIndex = 9;
            lblpassword.Text = "Contraseña";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(465, 213);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(248, 23);
            txtpassword.TabIndex = 1;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.FromArgb(2, 136, 209);
            btningresar.Cursor = Cursors.Hand;
            btningresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btningresar.ForeColor = Color.White;
            btningresar.Location = new Point(465, 260);
            btningresar.Margin = new Padding(3, 2, 3, 2);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(248, 36);
            btningresar.TabIndex = 2;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(0, 150, 136);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(465, 308);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(248, 36);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar Paciente";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSalir.ForeColor = Color.OrangeRed;
            lblSalir.Location = new Point(565, 365);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(41, 21);
            lblSalir.TabIndex = 4;
            lblSalir.Text = "Salir";
            lblSalir.Click += lblSalir_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(-1, -3);
            label1.Name = "label1";
            label1.Size = new Size(396, 507);
            label1.TabIndex = 15;
            // 
            // FormLogin
            // 
            AcceptButton = btningresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 38, 56);
            ClientSize = new Size(794, 502);
            Controls.Add(label1);
            Controls.Add(lblSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(btningresar);
            Controls.Add(txtpassword);
            Controls.Add(lblpassword);
            Controls.Add(txtusuario);
            Controls.Add(label3);
            Controls.Add(lblusuario);
            Controls.Add(lbltitulo);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalir;

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}
