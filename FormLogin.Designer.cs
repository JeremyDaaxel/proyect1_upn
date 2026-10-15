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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btncita = new Button();
            btntopico = new Button();
            btndoctor = new Button();
            btnregistrar = new Button();
            lbltitulo = new Label();
            lblusuario = new Label();
            label3 = new Label();
            txtusuario = new TextBox();
            btnsalir = new Button();
            lblpassword = new Label();
            txtpassword = new TextBox();
            btningresar = new Button();
            SuspendLayout();
            // 
            // btncita
            // 
            btncita.BackColor = Color.FromArgb(2, 136, 209);
            btncita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncita.ForeColor = Color.White;
            btncita.Location = new Point(95, 166);
            btncita.Margin = new Padding(3, 2, 3, 2);
            btncita.Name = "btncita";
            btncita.Size = new Size(111, 35);
            btncita.TabIndex = 0;
            btncita.Text = "Cita";
            btncita.UseVisualStyleBackColor = false;
            btncita.Visible = false;
            btncita.Click += btncita_Click;
            // 
            // btntopico
            // 
            btntopico.BackColor = Color.FromArgb(2, 136, 209);
            btntopico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btntopico.ForeColor = Color.White;
            btntopico.Location = new Point(222, 166);
            btntopico.Margin = new Padding(3, 2, 3, 2);
            btntopico.Name = "btntopico";
            btntopico.Size = new Size(111, 35);
            btntopico.TabIndex = 1;
            btntopico.Text = "Topico";
            btntopico.UseVisualStyleBackColor = false;
            btntopico.Visible = false;
            btntopico.Click += btntopico_Click;
            // 
            // btndoctor
            // 
            btndoctor.BackColor = Color.FromArgb(2, 136, 209);
            btndoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btndoctor.ForeColor = Color.White;
            btndoctor.Location = new Point(351, 166);
            btndoctor.Margin = new Padding(3, 2, 3, 2);
            btndoctor.Name = "btndoctor";
            btndoctor.Size = new Size(111, 35);
            btndoctor.TabIndex = 2;
            btndoctor.Text = "Doctor";
            btndoctor.UseVisualStyleBackColor = false;
            btndoctor.Visible = false;
            btndoctor.Click += btndoctor_Click;
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.FromArgb(2, 136, 209);
            btnregistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnregistrar.ForeColor = Color.White;
            btnregistrar.Location = new Point(72, 236);
            btnregistrar.Margin = new Padding(3, 2, 3, 2);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(134, 49);
            btnregistrar.TabIndex = 3;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Visible = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(247, 25);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(70, 27);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "Login";
            lbltitulo.Click += label1_Click;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.Location = new Point(83, 84);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(131, 15);
            lblusuario.TabIndex = 5;
            lblusuario.Text = "Usuario (DNI / Codigo)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(84, 243);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(84, 110);
            txtusuario.Margin = new Padding(3, 2, 3, 2);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(322, 23);
            txtusuario.TabIndex = 7;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(230, 81, 0);
            btnsalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(340, 240);
            btnsalir.Margin = new Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(122, 40);
            btnsalir.TabIndex = 8;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            //
            // lblpassword
            //
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(83, 146);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(90, 15);
            lblpassword.TabIndex = 9;
            lblpassword.Text = "Contraseña";
            //
            // txtpassword
            //
            txtpassword.Location = new Point(84, 172);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(322, 23);
            txtpassword.TabIndex = 10;
            txtpassword.UseSystemPasswordChar = true;
            //
            // btningresar
            //
            btningresar.BackColor = Color.FromArgb(2, 136, 209);
            btningresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btningresar.ForeColor = Color.White;
            btningresar.Location = new Point(84, 205);
            btningresar.Margin = new Padding(3, 2, 3, 2);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(322, 32);
            btningresar.TabIndex = 11;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            //
            // FormLogin
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 241);
            ClientSize = new Size(574, 338);
            Controls.Add(btningresar);
            Controls.Add(txtpassword);
            Controls.Add(lblpassword);
            Controls.Add(btnsalir);
            Controls.Add(txtusuario);
            Controls.Add(label3);
            Controls.Add(lblusuario);
            Controls.Add(lbltitulo);
            Controls.Add(btnregistrar);
            Controls.Add(btndoctor);
            Controls.Add(btntopico);
            Controls.Add(btncita);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncita;
        private Button btntopico;
        private Button btndoctor;
        private Button btnregistrar;
        private Label lbltitulo;
        private Label lblusuario;
        private Label label3;
        private TextBox txtusuario;
        private Button btnsalir;
        private Label lblpassword;
        private TextBox txtpassword;
        private Button btningresar;
    }
}
