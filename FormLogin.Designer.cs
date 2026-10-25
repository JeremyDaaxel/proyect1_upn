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
            lbltitulo = new System.Windows.Forms.Label();
            lblusuario = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtusuario = new System.Windows.Forms.TextBox();
            lblpassword = new System.Windows.Forms.Label();
            txtpassword = new System.Windows.Forms.TextBox();
            btningresar = new System.Windows.Forms.Button();
            btnRegistrar = new System.Windows.Forms.Button();
            lblSalir = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbltitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lbltitulo.Location = new System.Drawing.Point(500, 60);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new System.Drawing.Size(180, 37);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "Iniciar Sesión";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblusuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblusuario.Location = new System.Drawing.Point(465, 125);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new System.Drawing.Size(142, 17);
            lblusuario.TabIndex = 5;
            lblusuario.Text = "Usuario (DNI / Código)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(465, 430);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 15);
            label3.TabIndex = 6;
            // 
            // txtusuario
            // 
            txtusuario.Location = new System.Drawing.Point(465, 148);
            txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "doctor / topico / DNI";
            txtusuario.Size = new System.Drawing.Size(248, 23);
            txtusuario.TabIndex = 0;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblpassword.Location = new System.Drawing.Point(465, 190);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new System.Drawing.Size(74, 17);
            lblpassword.TabIndex = 9;
            lblpassword.Text = "Contraseña";
            // 
            // txtpassword
            // 
            txtpassword.Location = new System.Drawing.Point(465, 213);
            txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new System.Drawing.Size(248, 23);
            txtpassword.TabIndex = 1;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // btningresar
            // 
            btningresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)136)), ((int)((byte)209)));
            btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btningresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btningresar.ForeColor = System.Drawing.Color.White;
            btningresar.Location = new System.Drawing.Point(465, 260);
            btningresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btningresar.Name = "btningresar";
            btningresar.Size = new System.Drawing.Size(248, 36);
            btningresar.TabIndex = 2;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)150)), ((int)((byte)136)));
            btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnRegistrar.ForeColor = System.Drawing.Color.White;
            btnRegistrar.Location = new System.Drawing.Point(465, 308);
            btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(248, 36);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar Paciente";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            lblSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblSalir.ForeColor = System.Drawing.Color.OrangeRed;
            lblSalir.Location = new System.Drawing.Point(565, 365);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new System.Drawing.Size(41, 21);
            lblSalir.TabIndex = 4;
            lblSalir.Text = "Salir";
            lblSalir.Click += lblSalir_Click;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Image = ((System.Drawing.Image)resources.GetObject("label1.Image"));
            label1.Location = new System.Drawing.Point(-1, -3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(396, 507);
            label1.TabIndex = 15;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)38)), ((int)((byte)56)));
            ClientSize = new System.Drawing.Size(794, 502);
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
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
